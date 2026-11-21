using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000C7 RID: 199
	internal sealed class FSharpCoreReflectionProxy
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public static bool IsFSharpType(Type type)
		{
			if (FSharpCoreReflectionProxy.s_singletonInstance != null)
			{
				return FSharpCoreReflectionProxy.s_singletonInstance.GetFSharpCompilationMappingAttribute(type) != null;
			}
			Assembly fsharpCoreAssembly = FSharpCoreReflectionProxy.GetFSharpCoreAssembly(type);
			if (fsharpCoreAssembly != null)
			{
				if (FSharpCoreReflectionProxy.s_singletonInstance == null)
				{
					FSharpCoreReflectionProxy.s_singletonInstance = new FSharpCoreReflectionProxy(fsharpCoreAssembly);
				}
				return true;
			}
			return false;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0002D015 File Offset: 0x0002B215
		public static FSharpCoreReflectionProxy Instance
		{
			get
			{
				return FSharpCoreReflectionProxy.s_singletonInstance;
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002D01C File Offset: 0x0002B21C
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		private FSharpCoreReflectionProxy(Assembly fsharpCoreAssembly)
		{
			Type type = fsharpCoreAssembly.GetType("Microsoft.FSharp.Core.CompilationMappingAttribute");
			this._sourceConstructFlagsGetter = type.GetMethod("get_SourceConstructFlags", BindingFlags.Instance | BindingFlags.Public);
			this._compilationMappingAttributeType = type;
			this._fsharpOptionType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Core.FSharpOption`1");
			this._fsharpValueOptionType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Core.FSharpValueOption`1");
			this._fsharpListType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.FSharpList`1");
			this._fsharpSetType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.FSharpSet`1");
			this._fsharpMapType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
			Type type2 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.ListModule");
			this._fsharpListCtor = ((type2 != null) ? type2.GetMethod("OfSeq", BindingFlags.Static | BindingFlags.Public) : null);
			Type type3 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.SetModule");
			this._fsharpSetCtor = ((type3 != null) ? type3.GetMethod("OfSeq", BindingFlags.Static | BindingFlags.Public) : null);
			Type type4 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.MapModule");
			this._fsharpMapCtor = ((type4 != null) ? type4.GetMethod("OfSeq", BindingFlags.Static | BindingFlags.Public) : null);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002D118 File Offset: 0x0002B318
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpCoreReflectionProxy.FSharpKind DetectFSharpKind(Type type)
		{
			Attribute fsharpCompilationMappingAttribute = this.GetFSharpCompilationMappingAttribute(type);
			if (fsharpCompilationMappingAttribute == null)
			{
				return FSharpCoreReflectionProxy.FSharpKind.Unrecognized;
			}
			if (type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == this._fsharpOptionType)
				{
					return FSharpCoreReflectionProxy.FSharpKind.Option;
				}
				if (genericTypeDefinition == this._fsharpValueOptionType)
				{
					return FSharpCoreReflectionProxy.FSharpKind.ValueOption;
				}
				if (genericTypeDefinition == this._fsharpListType)
				{
					return FSharpCoreReflectionProxy.FSharpKind.List;
				}
				if (genericTypeDefinition == this._fsharpSetType)
				{
					return FSharpCoreReflectionProxy.FSharpKind.Set;
				}
				if (genericTypeDefinition == this._fsharpMapType)
				{
					return FSharpCoreReflectionProxy.FSharpKind.Map;
				}
			}
			FSharpCoreReflectionProxy.SourceConstructFlags sourceConstructFlags = this.GetSourceConstructFlags(fsharpCompilationMappingAttribute) & FSharpCoreReflectionProxy.SourceConstructFlags.KindMask;
			FSharpCoreReflectionProxy.FSharpKind result;
			if (sourceConstructFlags != FSharpCoreReflectionProxy.SourceConstructFlags.SumType)
			{
				if (sourceConstructFlags == FSharpCoreReflectionProxy.SourceConstructFlags.RecordType)
				{
					result = FSharpCoreReflectionProxy.FSharpKind.Record;
				}
				else
				{
					result = FSharpCoreReflectionProxy.FSharpKind.Unrecognized;
				}
			}
			else
			{
				result = FSharpCoreReflectionProxy.FSharpKind.Union;
			}
			return result;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0002D1AF File Offset: 0x0002B3AF
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public Func<TFSharpOption, T> CreateFSharpOptionValueGetter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TFSharpOption, T>()
		{
			return FSharpCoreReflectionProxy.CreateDelegate<Func<TFSharpOption, T>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(typeof(TFSharpOption).GetMethod("get_Value", BindingFlags.Instance | BindingFlags.Public), "Microsoft.FSharp.Core.FSharpOption<T>.get_Value()"));
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0002D1D6 File Offset: 0x0002B3D6
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public Func<TElement, TFSharpOption> CreateFSharpOptionSomeConstructor<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TFSharpOption, TElement>()
		{
			return FSharpCoreReflectionProxy.CreateDelegate<Func<TElement, TFSharpOption>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(typeof(TFSharpOption).GetMethod("Some", BindingFlags.Static | BindingFlags.Public), "Microsoft.FSharp.Core.FSharpOption<T>.Some(T value)"));
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0002D1FD File Offset: 0x0002B3FD
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpCoreReflectionProxy.StructGetter<TFSharpValueOption, TElement> CreateFSharpValueOptionValueGetter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TFSharpValueOption, TElement>() where TFSharpValueOption : struct
		{
			return FSharpCoreReflectionProxy.CreateDelegate<FSharpCoreReflectionProxy.StructGetter<TFSharpValueOption, TElement>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(typeof(TFSharpValueOption).GetMethod("get_Value", BindingFlags.Instance | BindingFlags.Public), "Microsoft.FSharp.Core.FSharpValueOption<T>.get_Value()"));
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002D224 File Offset: 0x0002B424
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public Func<TElement, TFSharpOption> CreateFSharpValueOptionSomeConstructor<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TFSharpOption, TElement>()
		{
			return FSharpCoreReflectionProxy.CreateDelegate<Func<TElement, TFSharpOption>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(typeof(TFSharpOption).GetMethod("Some", BindingFlags.Static | BindingFlags.Public), "Microsoft.FSharp.Core.FSharpValueOption<T>.ValueSome(T value)"));
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002D24B File Offset: 0x0002B44B
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public Func<IEnumerable<TElement>, TFSharpList> CreateFSharpListConstructor<TFSharpList, TElement>()
		{
			return FSharpCoreReflectionProxy.CreateDelegate<Func<IEnumerable<TElement>, TFSharpList>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(this._fsharpListCtor, "Microsoft.FSharp.Collections.ListModule.OfSeq<T>(IEnumerable<T> source)").MakeGenericMethod(new Type[]
			{
				typeof(TElement)
			}));
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002D27A File Offset: 0x0002B47A
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public Func<IEnumerable<TElement>, TFSharpSet> CreateFSharpSetConstructor<TFSharpSet, TElement>()
		{
			return FSharpCoreReflectionProxy.CreateDelegate<Func<IEnumerable<TElement>, TFSharpSet>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(this._fsharpSetCtor, "Microsoft.FSharp.Collections.SetModule.OfSeq<T>(IEnumerable<T> source)").MakeGenericMethod(new Type[]
			{
				typeof(TElement)
			}));
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002D2A9 File Offset: 0x0002B4A9
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public Func<IEnumerable<Tuple<TKey, TValue>>, TFSharpMap> CreateFSharpMapConstructor<TFSharpMap, TKey, TValue>()
		{
			return FSharpCoreReflectionProxy.CreateDelegate<Func<IEnumerable<Tuple<TKey, TValue>>, TFSharpMap>>(FSharpCoreReflectionProxy.EnsureMemberExists<MethodInfo>(this._fsharpMapCtor, "Microsoft.FSharp.Collections.MapModule.OfSeq<TKey, TValue>(IEnumerable<Tuple<TKey, TValue>> source)").MakeGenericMethod(new Type[]
			{
				typeof(TKey),
				typeof(TValue)
			}));
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002D2E5 File Offset: 0x0002B4E5
		private Attribute GetFSharpCompilationMappingAttribute(Type type)
		{
			return type.GetCustomAttribute(this._compilationMappingAttributeType, true);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002D2F4 File Offset: 0x0002B4F4
		private FSharpCoreReflectionProxy.SourceConstructFlags GetSourceConstructFlags(Attribute compilationMappingAttribute)
		{
			if (this._sourceConstructFlagsGetter != null)
			{
				return (FSharpCoreReflectionProxy.SourceConstructFlags)this._sourceConstructFlagsGetter.Invoke(compilationMappingAttribute, null);
			}
			return FSharpCoreReflectionProxy.SourceConstructFlags.None;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002D314 File Offset: 0x0002B514
		private static Assembly GetFSharpCoreAssembly(Type type)
		{
			object[] customAttributes = type.GetCustomAttributes(true);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				Type type2 = ((Attribute)customAttributes[i]).GetType();
				if (type2.FullName == "Microsoft.FSharp.Core.CompilationMappingAttribute")
				{
					return type2.Assembly;
				}
			}
			return null;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002D35F File Offset: 0x0002B55F
		private static TDelegate CreateDelegate<TDelegate>(MethodInfo methodInfo) where TDelegate : Delegate
		{
			return (TDelegate)((object)Delegate.CreateDelegate(typeof(TDelegate), methodInfo, true));
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002D377 File Offset: 0x0002B577
		private static TMemberInfo EnsureMemberExists<TMemberInfo>(TMemberInfo memberInfo, string memberName) where TMemberInfo : MemberInfo
		{
			if (memberInfo == null)
			{
				ThrowHelper.ThrowMissingMemberException_MissingFSharpCoreMember(memberName);
			}
			return memberInfo;
		}

		// Token: 0x04000314 RID: 788
		private static FSharpCoreReflectionProxy s_singletonInstance;

		// Token: 0x04000315 RID: 789
		private readonly Type _compilationMappingAttributeType;

		// Token: 0x04000316 RID: 790
		private readonly MethodInfo _sourceConstructFlagsGetter;

		// Token: 0x04000317 RID: 791
		private readonly Type _fsharpOptionType;

		// Token: 0x04000318 RID: 792
		private readonly Type _fsharpValueOptionType;

		// Token: 0x04000319 RID: 793
		private readonly Type _fsharpListType;

		// Token: 0x0400031A RID: 794
		private readonly Type _fsharpSetType;

		// Token: 0x0400031B RID: 795
		private readonly Type _fsharpMapType;

		// Token: 0x0400031C RID: 796
		private readonly MethodInfo _fsharpListCtor;

		// Token: 0x0400031D RID: 797
		private readonly MethodInfo _fsharpSetCtor;

		// Token: 0x0400031E RID: 798
		private readonly MethodInfo _fsharpMapCtor;

		// Token: 0x020000C8 RID: 200
		public enum FSharpKind
		{
			// Token: 0x04000320 RID: 800
			Unrecognized,
			// Token: 0x04000321 RID: 801
			Option,
			// Token: 0x04000322 RID: 802
			ValueOption,
			// Token: 0x04000323 RID: 803
			List,
			// Token: 0x04000324 RID: 804
			Set,
			// Token: 0x04000325 RID: 805
			Map,
			// Token: 0x04000326 RID: 806
			Record,
			// Token: 0x04000327 RID: 807
			Union
		}

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x06000A7F RID: 2687
		public delegate TResult StructGetter<TStruct, TResult>(ref TStruct @this) where TStruct : struct;

		// Token: 0x020000CA RID: 202
		private enum SourceConstructFlags
		{
			// Token: 0x04000329 RID: 809
			None,
			// Token: 0x0400032A RID: 810
			SumType,
			// Token: 0x0400032B RID: 811
			RecordType,
			// Token: 0x0400032C RID: 812
			ObjectType,
			// Token: 0x0400032D RID: 813
			Field,
			// Token: 0x0400032E RID: 814
			Exception,
			// Token: 0x0400032F RID: 815
			Closure,
			// Token: 0x04000330 RID: 816
			Module,
			// Token: 0x04000331 RID: 817
			UnionCase,
			// Token: 0x04000332 RID: 818
			Value,
			// Token: 0x04000333 RID: 819
			KindMask = 31,
			// Token: 0x04000334 RID: 820
			NonPublicRepresentation
		}
	}
}
