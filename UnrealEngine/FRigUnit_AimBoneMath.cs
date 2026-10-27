using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000540 RID: 1344
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimBoneMath")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FRigUnit_AimBoneMath : FRigUnit_HighlevelBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060046B2 RID: 18098 RVA: 0x00068EBC File Offset: 0x000670BC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimBoneMath._ScriptStructPtr != 0) ? FRigUnit_AimBoneMath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimBoneMath", ref FRigUnit_AimBoneMath._ScriptStructPtr);
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x00068EE0 File Offset: 0x000670E0
		// (set) Token: 0x060046B4 RID: 18100 RVA: 0x00068EF4 File Offset: 0x000670F4
		public unsafe FTransform InputTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_InputTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_InputTransform) = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x00068F0C File Offset: 0x0006710C
		// (set) Token: 0x060046B6 RID: 18102 RVA: 0x00068F4F File Offset: 0x0006714F
		public FRigUnit_AimItem_Target Primary
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimItem_Target result;
				if ((result = this._Primary) == null)
				{
					result = (this._Primary = new FRigUnit_AimItem_Target(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Primary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimItem_Target.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Primary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x00068F70 File Offset: 0x00067170
		// (set) Token: 0x060046B8 RID: 18104 RVA: 0x00068FB3 File Offset: 0x000671B3
		public FRigUnit_AimItem_Target Secondary
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimItem_Target result;
				if ((result = this._Secondary) == null)
				{
					result = (this._Secondary = new FRigUnit_AimItem_Target(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Secondary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimItem_Target.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Secondary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x00068FD4 File Offset: 0x000671D4
		// (set) Token: 0x060046BA RID: 18106 RVA: 0x00068FE4 File Offset: 0x000671E4
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x00068FF5 File Offset: 0x000671F5
		// (set) Token: 0x060046BC RID: 18108 RVA: 0x00069009 File Offset: 0x00067209
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x00069020 File Offset: 0x00067220
		// (set) Token: 0x060046BE RID: 18110 RVA: 0x00069063 File Offset: 0x00067263
		public FRigUnit_AimBone_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimBone_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_AimBone_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimBone_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x00069084 File Offset: 0x00067284
		// (set) Token: 0x060046C0 RID: 18112 RVA: 0x000690C7 File Offset: 0x000672C7
		public FCachedRigElement PrimaryCachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._PrimaryCachedSpace) == null)
				{
					result = (this._PrimaryCachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_PrimaryCachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_PrimaryCachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x000690E8 File Offset: 0x000672E8
		// (set) Token: 0x060046C2 RID: 18114 RVA: 0x0006912B File Offset: 0x0006732B
		public FCachedRigElement SecondaryCachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._SecondaryCachedSpace) == null)
				{
					result = (this._SecondaryCachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_SecondaryCachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBoneMath.__PropertyOffset_SecondaryCachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x0006914C File Offset: 0x0006734C
		public FRigUnit_AimBoneMath()
		{
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x00069154 File Offset: 0x00067354
		public FRigUnit_AimBoneMath(FTransform InputTransform, FRigUnit_AimItem_Target Primary, FRigUnit_AimItem_Target Secondary, float Weight, FTransform Result, FRigUnit_AimBone_DebugSettings DebugSettings, FCachedRigElement PrimaryCachedSpace, FCachedRigElement SecondaryCachedSpace)
		{
			this.InputTransform = InputTransform;
			this.Primary = Primary;
			this.Secondary = Secondary;
			this.Weight = Weight;
			this.Result = Result;
			this.DebugSettings = DebugSettings;
			this.PrimaryCachedSpace = PrimaryCachedSpace;
			this.SecondaryCachedSpace = SecondaryCachedSpace;
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x000691A4 File Offset: 0x000673A4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimBoneMath.StaticStruct();
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x000691B0 File Offset: 0x000673B0
		[NullableContext(2)]
		public FRigUnit_AimBoneMath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x000691BA File Offset: 0x000673BA
		public FRigUnit_AimBoneMath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x000691C5 File Offset: 0x000673C5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimBoneMath(Pointer, false, true);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x000691CF File Offset: 0x000673CF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimBoneMath(Pointer, MemoryOwner);
		}

		// Token: 0x04002255 RID: 8789
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AimBoneMath";

		// Token: 0x04002256 RID: 8790
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002257 RID: 8791
		internal static int __PropertyOffset_InputTransform;

		// Token: 0x04002258 RID: 8792
		internal static int __PropertyOffset_Primary;

		// Token: 0x04002259 RID: 8793
		[Nullable(2)]
		private FRigUnit_AimItem_Target _Primary;

		// Token: 0x0400225A RID: 8794
		internal static int __PropertyOffset_Secondary;

		// Token: 0x0400225B RID: 8795
		[Nullable(2)]
		private FRigUnit_AimItem_Target _Secondary;

		// Token: 0x0400225C RID: 8796
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400225D RID: 8797
		internal static int __PropertyOffset_Result;

		// Token: 0x0400225E RID: 8798
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x0400225F RID: 8799
		[Nullable(2)]
		private FRigUnit_AimBone_DebugSettings _DebugSettings;

		// Token: 0x04002260 RID: 8800
		internal static int __PropertyOffset_PrimaryCachedSpace;

		// Token: 0x04002261 RID: 8801
		[Nullable(2)]
		private FCachedRigElement _PrimaryCachedSpace;

		// Token: 0x04002262 RID: 8802
		internal static int __PropertyOffset_SecondaryCachedSpace;

		// Token: 0x04002263 RID: 8803
		[Nullable(2)]
		private FCachedRigElement _SecondaryCachedSpace;
	}
}
