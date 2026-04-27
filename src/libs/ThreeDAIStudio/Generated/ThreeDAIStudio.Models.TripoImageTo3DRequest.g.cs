#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TripoImageTo3DRequest : global::System.IEquatable<TripoImageTo3DRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ThreeDAIStudio.TripoSharedGenerationRequest? SharedGeneration { get; init; }
#else
        public global::ThreeDAIStudio.TripoSharedGenerationRequest? SharedGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SharedGeneration))]
#endif
        public bool IsSharedGeneration => SharedGeneration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ThreeDAIStudio.TripoImageTo3DRequestVariant2? TripoImageTo3DRequestVariant2 { get; init; }
#else
        public global::ThreeDAIStudio.TripoImageTo3DRequestVariant2? TripoImageTo3DRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TripoImageTo3DRequestVariant2))]
#endif
        public bool IsTripoImageTo3DRequestVariant2 => TripoImageTo3DRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TripoImageTo3DRequest(global::ThreeDAIStudio.TripoSharedGenerationRequest value) => new TripoImageTo3DRequest((global::ThreeDAIStudio.TripoSharedGenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ThreeDAIStudio.TripoSharedGenerationRequest?(TripoImageTo3DRequest @this) => @this.SharedGeneration;

        /// <summary>
        /// 
        /// </summary>
        public TripoImageTo3DRequest(global::ThreeDAIStudio.TripoSharedGenerationRequest? value)
        {
            SharedGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TripoImageTo3DRequest(global::ThreeDAIStudio.TripoImageTo3DRequestVariant2 value) => new TripoImageTo3DRequest((global::ThreeDAIStudio.TripoImageTo3DRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ThreeDAIStudio.TripoImageTo3DRequestVariant2?(TripoImageTo3DRequest @this) => @this.TripoImageTo3DRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TripoImageTo3DRequest(global::ThreeDAIStudio.TripoImageTo3DRequestVariant2? value)
        {
            TripoImageTo3DRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TripoImageTo3DRequest(
            global::ThreeDAIStudio.TripoSharedGenerationRequest? sharedGeneration,
            global::ThreeDAIStudio.TripoImageTo3DRequestVariant2? tripoImageTo3DRequestVariant2
            )
        {
            SharedGeneration = sharedGeneration;
            TripoImageTo3DRequestVariant2 = tripoImageTo3DRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TripoImageTo3DRequestVariant2 as object ??
            SharedGeneration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SharedGeneration?.ToString() ??
            TripoImageTo3DRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSharedGeneration && IsTripoImageTo3DRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ThreeDAIStudio.TripoSharedGenerationRequest?, TResult>? sharedGeneration = null,
            global::System.Func<global::ThreeDAIStudio.TripoImageTo3DRequestVariant2?, TResult>? tripoImageTo3DRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedGeneration && sharedGeneration != null)
            {
                return sharedGeneration(SharedGeneration!);
            }
            else if (IsTripoImageTo3DRequestVariant2 && tripoImageTo3DRequestVariant2 != null)
            {
                return tripoImageTo3DRequestVariant2(TripoImageTo3DRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ThreeDAIStudio.TripoSharedGenerationRequest?>? sharedGeneration = null,
            global::System.Action<global::ThreeDAIStudio.TripoImageTo3DRequestVariant2?>? tripoImageTo3DRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSharedGeneration)
            {
                sharedGeneration?.Invoke(SharedGeneration!);
            }
            else if (IsTripoImageTo3DRequestVariant2)
            {
                tripoImageTo3DRequestVariant2?.Invoke(TripoImageTo3DRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SharedGeneration,
                typeof(global::ThreeDAIStudio.TripoSharedGenerationRequest),
                TripoImageTo3DRequestVariant2,
                typeof(global::ThreeDAIStudio.TripoImageTo3DRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TripoImageTo3DRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ThreeDAIStudio.TripoSharedGenerationRequest?>.Default.Equals(SharedGeneration, other.SharedGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::ThreeDAIStudio.TripoImageTo3DRequestVariant2?>.Default.Equals(TripoImageTo3DRequestVariant2, other.TripoImageTo3DRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TripoImageTo3DRequest obj1, TripoImageTo3DRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TripoImageTo3DRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TripoImageTo3DRequest obj1, TripoImageTo3DRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TripoImageTo3DRequest o && Equals(o);
        }
    }
}
