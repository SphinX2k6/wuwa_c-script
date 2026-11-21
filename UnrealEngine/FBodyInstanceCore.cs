using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007B2 RID: 1970
	[UnrealObjectPath("/Script/PhysicsCore.BodyInstanceCore")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBodyInstanceCore : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AB31 RID: 43825 RVA: 0x000FC757 File Offset: 0x000FA957
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBodyInstanceCore._ScriptStructPtr != 0) ? FBodyInstanceCore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PhysicsCore.BodyInstanceCore", ref FBodyInstanceCore._ScriptStructPtr);
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x0600AB32 RID: 43826 RVA: 0x000FC77B File Offset: 0x000FA97B
		// (set) Token: 0x0600AB33 RID: 43827 RVA: 0x000FC794 File Offset: 0x000FA994
		public unsafe bool bSimulatePhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bSimulatePhysics) & FBodyInstanceCore.__PropertyMask_bSimulatePhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bSimulatePhysics) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bSimulatePhysics) & ~FBodyInstanceCore.__PropertyMask_bSimulatePhysics) | (value ? FBodyInstanceCore.__PropertyMask_bSimulatePhysics : 0));
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x0600AB34 RID: 43828 RVA: 0x000FC7C4 File Offset: 0x000FA9C4
		// (set) Token: 0x0600AB35 RID: 43829 RVA: 0x000FC7DD File Offset: 0x000FA9DD
		public unsafe bool bOverrideMass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bOverrideMass) & FBodyInstanceCore.__PropertyMask_bOverrideMass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bOverrideMass) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bOverrideMass) & ~FBodyInstanceCore.__PropertyMask_bOverrideMass) | (value ? FBodyInstanceCore.__PropertyMask_bOverrideMass : 0));
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x0600AB36 RID: 43830 RVA: 0x000FC80D File Offset: 0x000FAA0D
		// (set) Token: 0x0600AB37 RID: 43831 RVA: 0x000FC826 File Offset: 0x000FAA26
		public unsafe bool bEnableGravity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bEnableGravity) & FBodyInstanceCore.__PropertyMask_bEnableGravity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bEnableGravity) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bEnableGravity) & ~FBodyInstanceCore.__PropertyMask_bEnableGravity) | (value ? FBodyInstanceCore.__PropertyMask_bEnableGravity : 0));
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x0600AB38 RID: 43832 RVA: 0x000FC856 File Offset: 0x000FAA56
		// (set) Token: 0x0600AB39 RID: 43833 RVA: 0x000FC86F File Offset: 0x000FAA6F
		public unsafe bool bAutoWeld
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bAutoWeld) & FBodyInstanceCore.__PropertyMask_bAutoWeld) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bAutoWeld) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bAutoWeld) & ~FBodyInstanceCore.__PropertyMask_bAutoWeld) | (value ? FBodyInstanceCore.__PropertyMask_bAutoWeld : 0));
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x000FC89F File Offset: 0x000FAA9F
		// (set) Token: 0x0600AB3B RID: 43835 RVA: 0x000FC8B8 File Offset: 0x000FAAB8
		public unsafe bool bStartAwake
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bStartAwake) & FBodyInstanceCore.__PropertyMask_bStartAwake) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bStartAwake) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bStartAwake) & ~FBodyInstanceCore.__PropertyMask_bStartAwake) | (value ? FBodyInstanceCore.__PropertyMask_bStartAwake : 0));
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600AB3C RID: 43836 RVA: 0x000FC8E8 File Offset: 0x000FAAE8
		// (set) Token: 0x0600AB3D RID: 43837 RVA: 0x000FC901 File Offset: 0x000FAB01
		public unsafe bool bGenerateWakeEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bGenerateWakeEvents) & FBodyInstanceCore.__PropertyMask_bGenerateWakeEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bGenerateWakeEvents) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bGenerateWakeEvents) & ~FBodyInstanceCore.__PropertyMask_bGenerateWakeEvents) | (value ? FBodyInstanceCore.__PropertyMask_bGenerateWakeEvents : 0));
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x000FC931 File Offset: 0x000FAB31
		// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x000FC94A File Offset: 0x000FAB4A
		public unsafe bool bUpdateMassWhenScaleChanges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bUpdateMassWhenScaleChanges) & FBodyInstanceCore.__PropertyMask_bUpdateMassWhenScaleChanges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bUpdateMassWhenScaleChanges) = ((*(base.NativePtr + (IntPtr)FBodyInstanceCore.__PropertyOffset_bUpdateMassWhenScaleChanges) & ~FBodyInstanceCore.__PropertyMask_bUpdateMassWhenScaleChanges) | (value ? FBodyInstanceCore.__PropertyMask_bUpdateMassWhenScaleChanges : 0));
			}
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x000FC97A File Offset: 0x000FAB7A
		public FBodyInstanceCore()
		{
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x000FC982 File Offset: 0x000FAB82
		protected override IntPtr GetUStructPtr()
		{
			return FBodyInstanceCore.StaticStruct();
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x000FC98E File Offset: 0x000FAB8E
		[NullableContext(2)]
		public FBodyInstanceCore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x000FC998 File Offset: 0x000FAB98
		public FBodyInstanceCore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x000FC9A3 File Offset: 0x000FABA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBodyInstanceCore(Pointer, false, true);
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x000FC9AD File Offset: 0x000FABAD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBodyInstanceCore(Pointer, MemoryOwner);
		}

		// Token: 0x04004933 RID: 18739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PhysicsCore.BodyInstanceCore";

		// Token: 0x04004934 RID: 18740
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004935 RID: 18741
		internal static int __PropertyOffset_bSimulatePhysics;

		// Token: 0x04004936 RID: 18742
		internal static byte __PropertyMask_bSimulatePhysics;

		// Token: 0x04004937 RID: 18743
		internal static int __PropertyOffset_bOverrideMass;

		// Token: 0x04004938 RID: 18744
		internal static byte __PropertyMask_bOverrideMass;

		// Token: 0x04004939 RID: 18745
		internal static int __PropertyOffset_bEnableGravity;

		// Token: 0x0400493A RID: 18746
		internal static byte __PropertyMask_bEnableGravity;

		// Token: 0x0400493B RID: 18747
		internal static int __PropertyOffset_bAutoWeld;

		// Token: 0x0400493C RID: 18748
		internal static byte __PropertyMask_bAutoWeld;

		// Token: 0x0400493D RID: 18749
		internal static int __PropertyOffset_bStartAwake;

		// Token: 0x0400493E RID: 18750
		internal static byte __PropertyMask_bStartAwake;

		// Token: 0x0400493F RID: 18751
		internal static int __PropertyOffset_bGenerateWakeEvents;

		// Token: 0x04004940 RID: 18752
		internal static byte __PropertyMask_bGenerateWakeEvents;

		// Token: 0x04004941 RID: 18753
		internal static int __PropertyOffset_bUpdateMassWhenScaleChanges;

		// Token: 0x04004942 RID: 18754
		internal static byte __PropertyMask_bUpdateMassWhenScaleChanges;
	}
}
