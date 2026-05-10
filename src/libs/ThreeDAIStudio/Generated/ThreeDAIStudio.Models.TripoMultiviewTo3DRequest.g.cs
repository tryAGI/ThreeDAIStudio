#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TripoMultiviewTo3DRequest : global::System.IEquatable<TripoMultiviewTo3DRequest>
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
        public bool TryPickSharedGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ThreeDAIStudio.TripoSharedGenerationRequest? value)
        {
            value = SharedGeneration;
            return IsSharedGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2? TripoMultiviewTo3DRequestVariant2 { get; init; }
#else
        public global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2? TripoMultiviewTo3DRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TripoMultiviewTo3DRequestVariant2))]
#endif
        public bool IsTripoMultiviewTo3DRequestVariant2 => TripoMultiviewTo3DRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTripoMultiviewTo3DRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2? value)
        {
            value = TripoMultiviewTo3DRequestVariant2;
            return IsTripoMultiviewTo3DRequestVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TripoMultiviewTo3DRequest(global::ThreeDAIStudio.TripoSharedGenerationRequest value) => new TripoMultiviewTo3DRequest((global::ThreeDAIStudio.TripoSharedGenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ThreeDAIStudio.TripoSharedGenerationRequest?(TripoMultiviewTo3DRequest @this) => @this.SharedGeneration;

        /// <summary>
        /// 
        /// </summary>
        public TripoMultiviewTo3DRequest(global::ThreeDAIStudio.TripoSharedGenerationRequest? value)
        {
            SharedGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TripoMultiviewTo3DRequest FromSharedGeneration(global::ThreeDAIStudio.TripoSharedGenerationRequest? value) => new TripoMultiviewTo3DRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TripoMultiviewTo3DRequest(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2 value) => new TripoMultiviewTo3DRequest((global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2?(TripoMultiviewTo3DRequest @this) => @this.TripoMultiviewTo3DRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TripoMultiviewTo3DRequest(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2? value)
        {
            TripoMultiviewTo3DRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TripoMultiviewTo3DRequest FromTripoMultiviewTo3DRequestVariant2(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2? value) => new TripoMultiviewTo3DRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public TripoMultiviewTo3DRequest(
            global::ThreeDAIStudio.TripoSharedGenerationRequest? sharedGeneration,
            global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2? tripoMultiviewTo3DRequestVariant2
            )
        {
            SharedGeneration = sharedGeneration;
            TripoMultiviewTo3DRequestVariant2 = tripoMultiviewTo3DRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TripoMultiviewTo3DRequestVariant2 as object ??
            SharedGeneration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SharedGeneration?.ToString() ??
            TripoMultiviewTo3DRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSharedGeneration && IsTripoMultiviewTo3DRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ThreeDAIStudio.TripoSharedGenerationRequest, TResult>? sharedGeneration = null,
            global::System.Func<global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2, TResult>? tripoMultiviewTo3DRequestVariant2 = null,
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
            else if (IsTripoMultiviewTo3DRequestVariant2 && tripoMultiviewTo3DRequestVariant2 != null)
            {
                return tripoMultiviewTo3DRequestVariant2(TripoMultiviewTo3DRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ThreeDAIStudio.TripoSharedGenerationRequest>? sharedGeneration = null,

            global::System.Action<global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2>? tripoMultiviewTo3DRequestVariant2 = null,
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
            else if (IsTripoMultiviewTo3DRequestVariant2)
            {
                tripoMultiviewTo3DRequestVariant2?.Invoke(TripoMultiviewTo3DRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ThreeDAIStudio.TripoSharedGenerationRequest>? sharedGeneration = null,
            global::System.Action<global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2>? tripoMultiviewTo3DRequestVariant2 = null,
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
            else if (IsTripoMultiviewTo3DRequestVariant2)
            {
                tripoMultiviewTo3DRequestVariant2?.Invoke(TripoMultiviewTo3DRequestVariant2!);
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
                TripoMultiviewTo3DRequestVariant2,
                typeof(global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2),
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
        public bool Equals(TripoMultiviewTo3DRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ThreeDAIStudio.TripoSharedGenerationRequest?>.Default.Equals(SharedGeneration, other.SharedGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::ThreeDAIStudio.TripoMultiviewTo3DRequestVariant2?>.Default.Equals(TripoMultiviewTo3DRequestVariant2, other.TripoMultiviewTo3DRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TripoMultiviewTo3DRequest obj1, TripoMultiviewTo3DRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TripoMultiviewTo3DRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TripoMultiviewTo3DRequest obj1, TripoMultiviewTo3DRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TripoMultiviewTo3DRequest o && Equals(o);
        }
    }
}
