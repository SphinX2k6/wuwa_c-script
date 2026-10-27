using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DE6 RID: 7654
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_FXParam")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKSC_FXParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D3F0 RID: 119792 RVA: 0x002B304D File Offset: 0x002B124D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_FXParam._ScriptStructPtr != 0) ? FKSC_FXParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_FXParam", ref FKSC_FXParam._ScriptStructPtr);
		}

		// Token: 0x17007613 RID: 30227
		// (get) Token: 0x0601D3F1 RID: 119793 RVA: 0x002B3071 File Offset: 0x002B1271
		// (set) Token: 0x0601D3F2 RID: 119794 RVA: 0x002B3085 File Offset: 0x002B1285
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17007614 RID: 30228
		// (get) Token: 0x0601D3F3 RID: 119795 RVA: 0x002B309A File Offset: 0x002B129A
		// (set) Token: 0x0601D3F4 RID: 119796 RVA: 0x002B30AA File Offset: 0x002B12AA
		public unsafe EKSC_FXValueType FXValueType
		{
			get
			{
				return (EKSC_FXValueType)(*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_FXValueType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_FXValueType) = (byte)value;
			}
		}

		// Token: 0x17007615 RID: 30229
		// (get) Token: 0x0601D3F5 RID: 119797 RVA: 0x002B30BB File Offset: 0x002B12BB
		// (set) Token: 0x0601D3F6 RID: 119798 RVA: 0x002B30CB File Offset: 0x002B12CB
		public unsafe EKSC_FXBindingType FXBindingType
		{
			get
			{
				return (EKSC_FXBindingType)(*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_FXBindingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_FXBindingType) = (byte)value;
			}
		}

		// Token: 0x17007616 RID: 30230
		// (get) Token: 0x0601D3F7 RID: 119799 RVA: 0x002B30DC File Offset: 0x002B12DC
		// (set) Token: 0x0601D3F8 RID: 119800 RVA: 0x002B30EC File Offset: 0x002B12EC
		public unsafe bool BindingWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_BindingWorldPos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_BindingWorldPos) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007617 RID: 30231
		// (get) Token: 0x0601D3F9 RID: 119801 RVA: 0x002B30FD File Offset: 0x002B12FD
		// (set) Token: 0x0601D3FA RID: 119802 RVA: 0x002B3111 File Offset: 0x002B1311
		public unsafe FVector VectorValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_VectorValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_VectorValue) = value;
			}
		}

		// Token: 0x17007618 RID: 30232
		// (get) Token: 0x0601D3FB RID: 119803 RVA: 0x002B3126 File Offset: 0x002B1326
		// (set) Token: 0x0601D3FC RID: 119804 RVA: 0x002B3136 File Offset: 0x002B1336
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_FXParam.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x0601D3FD RID: 119805 RVA: 0x002B3147 File Offset: 0x002B1347
		public FKSC_FXParam()
		{
		}

		// Token: 0x0601D3FE RID: 119806 RVA: 0x002B314F File Offset: 0x002B134F
		public FKSC_FXParam(FName ParamName, EKSC_FXValueType FXValueType, EKSC_FXBindingType FXBindingType, bool BindingWorldPos, FVector VectorValue, float FloatValue)
		{
			this.ParamName = ParamName;
			this.FXValueType = FXValueType;
			this.FXBindingType = FXBindingType;
			this.BindingWorldPos = BindingWorldPos;
			this.VectorValue = VectorValue;
			this.FloatValue = FloatValue;
		}

		// Token: 0x0601D3FF RID: 119807 RVA: 0x002B3184 File Offset: 0x002B1384
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_FXParam.StaticStruct();
		}

		// Token: 0x0601D400 RID: 119808 RVA: 0x002B3190 File Offset: 0x002B1390
		[NullableContext(2)]
		public FKSC_FXParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D401 RID: 119809 RVA: 0x002B319A File Offset: 0x002B139A
		public FKSC_FXParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D402 RID: 119810 RVA: 0x002B31A5 File Offset: 0x002B13A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_FXParam(Pointer, false, true);
		}

		// Token: 0x0601D403 RID: 119811 RVA: 0x002B31AF File Offset: 0x002B13AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_FXParam(Pointer, MemoryOwner);
		}

		// Token: 0x0400FDE9 RID: 65001
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_FXParam";

		// Token: 0x0400FDEA RID: 65002
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FDEB RID: 65003
		internal static int __PropertyOffset_ParamName;

		// Token: 0x0400FDEC RID: 65004
		internal static int __PropertyOffset_FXValueType;

		// Token: 0x0400FDED RID: 65005
		internal static int __PropertyOffset_FXBindingType;

		// Token: 0x0400FDEE RID: 65006
		internal static int __PropertyOffset_BindingWorldPos;

		// Token: 0x0400FDEF RID: 65007
		internal static int __PropertyOffset_VectorValue;

		// Token: 0x0400FDF0 RID: 65008
		internal static int __PropertyOffset_FloatValue;
	}
}
