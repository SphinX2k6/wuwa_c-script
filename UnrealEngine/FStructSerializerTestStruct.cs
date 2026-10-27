using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002724 RID: 10020
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Serialization.StructSerializerTestStruct")]
	[UnrealStructLayout(1152, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1152)]
	public class FStructSerializerTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025218 RID: 152088 RVA: 0x0036FD9E File Offset: 0x0036DF9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerTestStruct._ScriptStructPtr != 0) ? FStructSerializerTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerTestStruct", ref FStructSerializerTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F4D RID: 36685
		// (get) Token: 0x06025219 RID: 152089 RVA: 0x0036FDC4 File Offset: 0x0036DFC4
		// (set) Token: 0x0602521A RID: 152090 RVA: 0x0036FE07 File Offset: 0x0036E007
		public FStructSerializerNumericTestStruct Numerics
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerNumericTestStruct result;
				if ((result = this._Numerics) == null)
				{
					result = (this._Numerics = new FStructSerializerNumericTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Numerics, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerNumericTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Numerics, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F4E RID: 36686
		// (get) Token: 0x0602521B RID: 152091 RVA: 0x0036FE28 File Offset: 0x0036E028
		// (set) Token: 0x0602521C RID: 152092 RVA: 0x0036FE6B File Offset: 0x0036E06B
		public FStructSerializerBooleanTestStruct Booleans
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerBooleanTestStruct result;
				if ((result = this._Booleans) == null)
				{
					result = (this._Booleans = new FStructSerializerBooleanTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Booleans, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerBooleanTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Booleans, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F4F RID: 36687
		// (get) Token: 0x0602521D RID: 152093 RVA: 0x0036FE8C File Offset: 0x0036E08C
		// (set) Token: 0x0602521E RID: 152094 RVA: 0x0036FECF File Offset: 0x0036E0CF
		public FStructSerializerObjectTestStruct Objects
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerObjectTestStruct result;
				if ((result = this._Objects) == null)
				{
					result = (this._Objects = new FStructSerializerObjectTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Objects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerObjectTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Objects, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F50 RID: 36688
		// (get) Token: 0x0602521F RID: 152095 RVA: 0x0036FEF0 File Offset: 0x0036E0F0
		// (set) Token: 0x06025220 RID: 152096 RVA: 0x0036FF33 File Offset: 0x0036E133
		public FStructSerializerBuiltinTestStruct Builtins
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerBuiltinTestStruct result;
				if ((result = this._Builtins) == null)
				{
					result = (this._Builtins = new FStructSerializerBuiltinTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Builtins, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerBuiltinTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Builtins, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F51 RID: 36689
		// (get) Token: 0x06025221 RID: 152097 RVA: 0x0036FF54 File Offset: 0x0036E154
		// (set) Token: 0x06025222 RID: 152098 RVA: 0x0036FF97 File Offset: 0x0036E197
		public FStructSerializerArrayTestStruct Arrays
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerArrayTestStruct result;
				if ((result = this._Arrays) == null)
				{
					result = (this._Arrays = new FStructSerializerArrayTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Arrays, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerArrayTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Arrays, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F52 RID: 36690
		// (get) Token: 0x06025223 RID: 152099 RVA: 0x0036FFB8 File Offset: 0x0036E1B8
		// (set) Token: 0x06025224 RID: 152100 RVA: 0x0036FFFB File Offset: 0x0036E1FB
		public FStructSerializerMapTestStruct Maps
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerMapTestStruct result;
				if ((result = this._Maps) == null)
				{
					result = (this._Maps = new FStructSerializerMapTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Maps, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerMapTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Maps, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008F53 RID: 36691
		// (get) Token: 0x06025225 RID: 152101 RVA: 0x0037001C File Offset: 0x0036E21C
		// (set) Token: 0x06025226 RID: 152102 RVA: 0x0037005F File Offset: 0x0036E25F
		public FStructSerializerSetTestStruct Sets
		{
			get
			{
				base.FastCheckIsValid();
				FStructSerializerSetTestStruct result;
				if ((result = this._Sets) == null)
				{
					result = (this._Sets = new FStructSerializerSetTestStruct(base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Sets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStructSerializerSetTestStruct.StaticStruct(), base.NativePtr + (IntPtr)FStructSerializerTestStruct.__PropertyOffset_Sets, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025227 RID: 152103 RVA: 0x00370080 File Offset: 0x0036E280
		public FStructSerializerTestStruct()
		{
		}

		// Token: 0x06025228 RID: 152104 RVA: 0x00370088 File Offset: 0x0036E288
		public FStructSerializerTestStruct(FStructSerializerNumericTestStruct Numerics, FStructSerializerBooleanTestStruct Booleans, FStructSerializerObjectTestStruct Objects, FStructSerializerBuiltinTestStruct Builtins, FStructSerializerArrayTestStruct Arrays, FStructSerializerMapTestStruct Maps, FStructSerializerSetTestStruct Sets)
		{
			this.Numerics = Numerics;
			this.Booleans = Booleans;
			this.Objects = Objects;
			this.Builtins = Builtins;
			this.Arrays = Arrays;
			this.Maps = Maps;
			this.Sets = Sets;
		}

		// Token: 0x06025229 RID: 152105 RVA: 0x003700C5 File Offset: 0x0036E2C5
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerTestStruct.StaticStruct();
		}

		// Token: 0x0602522A RID: 152106 RVA: 0x003700D1 File Offset: 0x0036E2D1
		[NullableContext(2)]
		public FStructSerializerTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602522B RID: 152107 RVA: 0x003700DB File Offset: 0x0036E2DB
		public FStructSerializerTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602522C RID: 152108 RVA: 0x003700E6 File Offset: 0x0036E2E6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerTestStruct(Pointer, false, true);
		}

		// Token: 0x0602522D RID: 152109 RVA: 0x003700F0 File Offset: 0x0036E2F0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04014024 RID: 81956
		public const string __ObjectPath = "/Script/Serialization.StructSerializerTestStruct";

		// Token: 0x04014025 RID: 81957
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014026 RID: 81958
		internal static int __PropertyOffset_Numerics;

		// Token: 0x04014027 RID: 81959
		[Nullable(2)]
		private FStructSerializerNumericTestStruct _Numerics;

		// Token: 0x04014028 RID: 81960
		internal static int __PropertyOffset_Booleans;

		// Token: 0x04014029 RID: 81961
		[Nullable(2)]
		private FStructSerializerBooleanTestStruct _Booleans;

		// Token: 0x0401402A RID: 81962
		internal static int __PropertyOffset_Objects;

		// Token: 0x0401402B RID: 81963
		[Nullable(2)]
		private FStructSerializerObjectTestStruct _Objects;

		// Token: 0x0401402C RID: 81964
		internal static int __PropertyOffset_Builtins;

		// Token: 0x0401402D RID: 81965
		[Nullable(2)]
		private FStructSerializerBuiltinTestStruct _Builtins;

		// Token: 0x0401402E RID: 81966
		internal static int __PropertyOffset_Arrays;

		// Token: 0x0401402F RID: 81967
		[Nullable(2)]
		private FStructSerializerArrayTestStruct _Arrays;

		// Token: 0x04014030 RID: 81968
		internal static int __PropertyOffset_Maps;

		// Token: 0x04014031 RID: 81969
		[Nullable(2)]
		private FStructSerializerMapTestStruct _Maps;

		// Token: 0x04014032 RID: 81970
		internal static int __PropertyOffset_Sets;

		// Token: 0x04014033 RID: 81971
		[Nullable(2)]
		private FStructSerializerSetTestStruct _Sets;
	}
}
