using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053F RID: 1343
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimBone")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FRigUnit_AimBone : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004698 RID: 18072 RVA: 0x00068B37 File Offset: 0x00066D37
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimBone._ScriptStructPtr != 0) ? FRigUnit_AimBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimBone", ref FRigUnit_AimBone._ScriptStructPtr);
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06004699 RID: 18073 RVA: 0x00068B5B File Offset: 0x00066D5B
		// (set) Token: 0x0600469A RID: 18074 RVA: 0x00068B6F File Offset: 0x00066D6F
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x0600469B RID: 18075 RVA: 0x00068B84 File Offset: 0x00066D84
		// (set) Token: 0x0600469C RID: 18076 RVA: 0x00068BC7 File Offset: 0x00066DC7
		public FRigUnit_AimBone_Target Primary
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimBone_Target result;
				if ((result = this._Primary) == null)
				{
					result = (this._Primary = new FRigUnit_AimBone_Target(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Primary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimBone_Target.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Primary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x0600469D RID: 18077 RVA: 0x00068BE8 File Offset: 0x00066DE8
		// (set) Token: 0x0600469E RID: 18078 RVA: 0x00068C2B File Offset: 0x00066E2B
		public FRigUnit_AimBone_Target Secondary
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimBone_Target result;
				if ((result = this._Secondary) == null)
				{
					result = (this._Secondary = new FRigUnit_AimBone_Target(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Secondary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimBone_Target.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Secondary, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x00068C4C File Offset: 0x00066E4C
		// (set) Token: 0x060046A0 RID: 18080 RVA: 0x00068C5C File Offset: 0x00066E5C
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060046A1 RID: 18081 RVA: 0x00068C6D File Offset: 0x00066E6D
		// (set) Token: 0x060046A2 RID: 18082 RVA: 0x00068C7D File Offset: 0x00066E7D
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x00068C90 File Offset: 0x00066E90
		// (set) Token: 0x060046A4 RID: 18084 RVA: 0x00068CD3 File Offset: 0x00066ED3
		public FRigUnit_AimBone_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimBone_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_AimBone_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimBone_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x00068CF4 File Offset: 0x00066EF4
		// (set) Token: 0x060046A6 RID: 18086 RVA: 0x00068D37 File Offset: 0x00066F37
		public FCachedRigElement CachedBoneIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBoneIndex) == null)
				{
					result = (this._CachedBoneIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_CachedBoneIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_CachedBoneIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x00068D58 File Offset: 0x00066F58
		// (set) Token: 0x060046A8 RID: 18088 RVA: 0x00068D9B File Offset: 0x00066F9B
		public FCachedRigElement PrimaryCachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._PrimaryCachedSpace) == null)
				{
					result = (this._PrimaryCachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_PrimaryCachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_PrimaryCachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x00068DBC File Offset: 0x00066FBC
		// (set) Token: 0x060046AA RID: 18090 RVA: 0x00068DFF File Offset: 0x00066FFF
		public FCachedRigElement SecondaryCachedSpace
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._SecondaryCachedSpace) == null)
				{
					result = (this._SecondaryCachedSpace = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_SecondaryCachedSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimBone.__PropertyOffset_SecondaryCachedSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x00068E20 File Offset: 0x00067020
		public FRigUnit_AimBone()
		{
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00068E28 File Offset: 0x00067028
		public FRigUnit_AimBone(FName Bone, FRigUnit_AimBone_Target Primary, FRigUnit_AimBone_Target Secondary, float Weight, bool bPropagateToChildren, FRigUnit_AimBone_DebugSettings DebugSettings, FCachedRigElement CachedBoneIndex, FCachedRigElement PrimaryCachedSpace, FCachedRigElement SecondaryCachedSpace, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Primary = Primary;
			this.Secondary = Secondary;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.DebugSettings = DebugSettings;
			this.CachedBoneIndex = CachedBoneIndex;
			this.PrimaryCachedSpace = PrimaryCachedSpace;
			this.SecondaryCachedSpace = SecondaryCachedSpace;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x00068E88 File Offset: 0x00067088
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimBone.StaticStruct();
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x00068E94 File Offset: 0x00067094
		[NullableContext(2)]
		public FRigUnit_AimBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x00068E9E File Offset: 0x0006709E
		public FRigUnit_AimBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x00068EA9 File Offset: 0x000670A9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimBone(Pointer, false, true);
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x00068EB3 File Offset: 0x000670B3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimBone(Pointer, MemoryOwner);
		}

		// Token: 0x04002244 RID: 8772
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AimBone";

		// Token: 0x04002245 RID: 8773
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002246 RID: 8774
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002247 RID: 8775
		internal static int __PropertyOffset_Primary;

		// Token: 0x04002248 RID: 8776
		[Nullable(2)]
		private FRigUnit_AimBone_Target _Primary;

		// Token: 0x04002249 RID: 8777
		internal static int __PropertyOffset_Secondary;

		// Token: 0x0400224A RID: 8778
		[Nullable(2)]
		private FRigUnit_AimBone_Target _Secondary;

		// Token: 0x0400224B RID: 8779
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400224C RID: 8780
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x0400224D RID: 8781
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x0400224E RID: 8782
		[Nullable(2)]
		private FRigUnit_AimBone_DebugSettings _DebugSettings;

		// Token: 0x0400224F RID: 8783
		internal static int __PropertyOffset_CachedBoneIndex;

		// Token: 0x04002250 RID: 8784
		[Nullable(2)]
		private FCachedRigElement _CachedBoneIndex;

		// Token: 0x04002251 RID: 8785
		internal static int __PropertyOffset_PrimaryCachedSpace;

		// Token: 0x04002252 RID: 8786
		[Nullable(2)]
		private FCachedRigElement _PrimaryCachedSpace;

		// Token: 0x04002253 RID: 8787
		internal static int __PropertyOffset_SecondaryCachedSpace;

		// Token: 0x04002254 RID: 8788
		[Nullable(2)]
		private FCachedRigElement _SecondaryCachedSpace;
	}
}
