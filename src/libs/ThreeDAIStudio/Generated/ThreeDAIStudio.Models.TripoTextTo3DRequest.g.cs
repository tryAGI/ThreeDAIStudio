#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ThreeDAIStudio
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TripoTextTo3DRequest : global::System.IEquatable<TripoTextTo3DRequest>
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
        public global::ThreeDAIStudio.TripoTextTo3DRequestVariant2? TripoTextTo3DRequestVariant2 { get; init; }
#else
        public global::ThreeDAIStudio.TripoTextTo3DRequestVariant2? TripoTextTo3DRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TripoTextTo3DRequestVariant2))]
#endif
        public bool IsTripoTextTo3DRequestVariant2 => TripoTextTo3DRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTripoTextTo3DRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ThreeDAIStudio.TripoTextTo3DRequestVariant2? value)
        {
            value = TripoTextTo3DRequestVariant2;
            return IsTripoTextTo3DRequestVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TripoTextTo3DRequest(global::ThreeDAIStudio.TripoSharedGenerationRequest value) => new TripoTextTo3DRequest((global::ThreeDAIStudio.TripoSharedGenerationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ThreeDAIStudio.TripoSharedGenerationRequest?(TripoTextTo3DRequest @this) => @this.SharedGeneration;

        /// <summary>
        /// 
        /// </summary>
        public TripoTextTo3DRequest(global::ThreeDAIStudio.TripoSharedGenerationRequest? value)
        {
            SharedGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TripoTextTo3DRequest(global::ThreeDAIStudio.TripoTextTo3DRequestVariant2 value) => new TripoTextTo3DRequest((global::ThreeDAIStudio.TripoTextTo3DRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ThreeDAIStudio.TripoTextTo3DRequestVariant2?(TripoTextTo3DRequest @this) => @this.TripoTextTo3DRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TripoTextTo3DRequest(global::ThreeDAIStudio.TripoTextTo3DRequestVariant2? value)
        {
            TripoTextTo3DRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TripoTextTo3DRequest(
            global::ThreeDAIStudio.TripoSharedGenerationRequest? sharedGeneration,
            global::ThreeDAIStudio.TripoTextTo3DRequestVariant2? tripoTextTo3DRequestVariant2
            )
        {
            SharedGeneration = sharedGeneration;
            TripoTextTo3DRequestVariant2 = tripoTextTo3DRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TripoTextTo3DRequestVariant2 as object ??
            SharedGeneration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SharedGeneration?.ToString() ??
            TripoTextTo3DRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSharedGeneration && IsTripoTextTo3DRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ThreeDAIStudio.TripoSharedGenerationRequest, TResult>? sharedGeneration = null,
            global::System.Func<global::ThreeDAIStudio.TripoTextTo3DRequestVariant2, TResult>? tripoTextTo3DRequestVariant2 = null,
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
            else if (IsTripoTextTo3DRequestVariant2 && tripoTextTo3DRequestVariant2 != null)
            {
                return tripoTextTo3DRequestVariant2(TripoTextTo3DRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ThreeDAIStudio.TripoSharedGenerationRequest>? sharedGeneration = null,

            global::System.Action<global::ThreeDAIStudio.TripoTextTo3DRequestVariant2>? tripoTextTo3DRequestVariant2 = null,
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
            else if (IsTripoTextTo3DRequestVariant2)
            {
                tripoTextTo3DRequestVariant2?.Invoke(TripoTextTo3DRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ThreeDAIStudio.TripoSharedGenerationRequest>? sharedGeneration = null,
            global::System.Action<global::ThreeDAIStudio.TripoTextTo3DRequestVariant2>? tripoTextTo3DRequestVariant2 = null,
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
            else if (IsTripoTextTo3DRequestVariant2)
            {
                tripoTextTo3DRequestVariant2?.Invoke(TripoTextTo3DRequestVariant2!);
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
                TripoTextTo3DRequestVariant2,
                typeof(global::ThreeDAIStudio.TripoTextTo3DRequestVariant2),
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
        public bool Equals(TripoTextTo3DRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ThreeDAIStudio.TripoSharedGenerationRequest?>.Default.Equals(SharedGeneration, other.SharedGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::ThreeDAIStudio.TripoTextTo3DRequestVariant2?>.Default.Equals(TripoTextTo3DRequestVariant2, other.TripoTextTo3DRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TripoTextTo3DRequest obj1, TripoTextTo3DRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TripoTextTo3DRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TripoTextTo3DRequest obj1, TripoTextTo3DRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TripoTextTo3DRequest o && Equals(o);
        }
    }
}
