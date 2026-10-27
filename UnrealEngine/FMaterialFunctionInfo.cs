using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E81 RID: 3713
	[UnrealObjectPath("/Script/Engine.MaterialFunctionInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMaterialFunctionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C644 RID: 50756 RVA: 0x0011F411 File Offset: 0x0011D611
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialFunctionInfo._ScriptStructPtr != 0) ? FMaterialFunctionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialFunctionInfo", ref FMaterialFunctionInfo._ScriptStructPtr);
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0600C645 RID: 50757 RVA: 0x0011F435 File Offset: 0x0011D635
		// (set) Token: 0x0600C646 RID: 50758 RVA: 0x0011F449 File Offset: 0x0011D649
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialFunctionInfo.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialFunctionInfo.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600C647 RID: 50759 RVA: 0x0011F45E File Offset: 0x0011D65E
		// (set) Token: 0x0600C648 RID: 50760 RVA: 0x0011F472 File Offset: 0x0011D672
		[Nullable(2)]
		public unsafe UMaterialFunctionInterface Function
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialFunctionInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialFunctionInfo.__PropertyOffset_Function);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMaterialFunctionInfo.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x0600C649 RID: 50761 RVA: 0x0011F487 File Offset: 0x0011D687
		public FMaterialFunctionInfo()
		{
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x0011F48F File Offset: 0x0011D68F
		[NullableContext(1)]
		public FMaterialFunctionInfo(FGuid StateId, UMaterialFunctionInterface Function)
		{
			this.StateId = StateId;
			this.Function = Function;
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x0011F4A5 File Offset: 0x0011D6A5
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialFunctionInfo.StaticStruct();
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x0011F4B1 File Offset: 0x0011D6B1
		[NullableContext(2)]
		public FMaterialFunctionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x0011F4BB File Offset: 0x0011D6BB
		public FMaterialFunctionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x0011F4C6 File Offset: 0x0011D6C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialFunctionInfo(Pointer, false, true);
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x0011F4D0 File Offset: 0x0011D6D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialFunctionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006A23 RID: 27171
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialFunctionInfo";

		// Token: 0x04006A24 RID: 27172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006A25 RID: 27173
		internal static int __PropertyOffset_StateId;

		// Token: 0x04006A26 RID: 27174
		internal static int __PropertyOffset_Function;
	}
}
