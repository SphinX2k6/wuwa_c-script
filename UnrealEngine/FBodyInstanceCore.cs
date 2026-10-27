using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002638 RID: 9784
	[UnrealObjectPath("/Script/PhysicsCore.BodyInstanceCore")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBodyInstanceCore : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602463F RID: 149055 RVA: 0x0035E063 File Offset: 0x0035C263
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBodyInstanceCore._ScriptStructPtr != 0) ? FBodyInstanceCore._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PhysicsCore.BodyInstanceCore", ref FBodyInstanceCore._ScriptStructPtr);
		}

		// Token: 0x17008C29 RID: 35881
		// (get) Token: 0x06024640 RID: 149056 RVA: 0x0035E087 File Offset: 0x0035C287
		// (set) Token: 0x06024641 RID: 149057 RVA: 0x0035E0A0 File Offset: 0x0035C2A0
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

		// Token: 0x17008C2A RID: 35882
		// (get) Token: 0x06024642 RID: 149058 RVA: 0x0035E0D0 File Offset: 0x0035C2D0
		// (set) Token: 0x06024643 RID: 149059 RVA: 0x0035E0E9 File Offset: 0x0035C2E9
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

		// Token: 0x17008C2B RID: 35883
		// (get) Token: 0x06024644 RID: 149060 RVA: 0x0035E119 File Offset: 0x0035C319
		// (set) Token: 0x06024645 RID: 149061 RVA: 0x0035E132 File Offset: 0x0035C332
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

		// Token: 0x17008C2C RID: 35884
		// (get) Token: 0x06024646 RID: 149062 RVA: 0x0035E162 File Offset: 0x0035C362
		// (set) Token: 0x06024647 RID: 149063 RVA: 0x0035E17B File Offset: 0x0035C37B
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

		// Token: 0x17008C2D RID: 35885
		// (get) Token: 0x06024648 RID: 149064 RVA: 0x0035E1AB File Offset: 0x0035C3AB
		// (set) Token: 0x06024649 RID: 149065 RVA: 0x0035E1C4 File Offset: 0x0035C3C4
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

		// Token: 0x17008C2E RID: 35886
		// (get) Token: 0x0602464A RID: 149066 RVA: 0x0035E1F4 File Offset: 0x0035C3F4
		// (set) Token: 0x0602464B RID: 149067 RVA: 0x0035E20D File Offset: 0x0035C40D
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

		// Token: 0x17008C2F RID: 35887
		// (get) Token: 0x0602464C RID: 149068 RVA: 0x0035E23D File Offset: 0x0035C43D
		// (set) Token: 0x0602464D RID: 149069 RVA: 0x0035E256 File Offset: 0x0035C456
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

		// Token: 0x0602464E RID: 149070 RVA: 0x0035E286 File Offset: 0x0035C486
		public FBodyInstanceCore()
		{
		}

		// Token: 0x0602464F RID: 149071 RVA: 0x0035E28E File Offset: 0x0035C48E
		public FBodyInstanceCore(bool bSimulatePhysics, bool bOverrideMass, bool bEnableGravity, bool bAutoWeld, bool bStartAwake, bool bGenerateWakeEvents, bool bUpdateMassWhenScaleChanges)
		{
			this.bSimulatePhysics = bSimulatePhysics;
			this.bOverrideMass = bOverrideMass;
			this.bEnableGravity = bEnableGravity;
			this.bAutoWeld = bAutoWeld;
			this.bStartAwake = bStartAwake;
			this.bGenerateWakeEvents = bGenerateWakeEvents;
			this.bUpdateMassWhenScaleChanges = bUpdateMassWhenScaleChanges;
		}

		// Token: 0x06024650 RID: 149072 RVA: 0x0035E2CB File Offset: 0x0035C4CB
		protected override IntPtr GetUStructPtr()
		{
			return FBodyInstanceCore.StaticStruct();
		}

		// Token: 0x06024651 RID: 149073 RVA: 0x0035E2D7 File Offset: 0x0035C4D7
		[NullableContext(2)]
		public FBodyInstanceCore(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024652 RID: 149074 RVA: 0x0035E2E1 File Offset: 0x0035C4E1
		public FBodyInstanceCore(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024653 RID: 149075 RVA: 0x0035E2EC File Offset: 0x0035C4EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBodyInstanceCore(Pointer, false, true);
		}

		// Token: 0x06024654 RID: 149076 RVA: 0x0035E2F6 File Offset: 0x0035C4F6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBodyInstanceCore(Pointer, MemoryOwner);
		}

		// Token: 0x0401384E RID: 79950
		[Nullable(1)]
		public const string __ObjectPath = "/Script/PhysicsCore.BodyInstanceCore";

		// Token: 0x0401384F RID: 79951
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013850 RID: 79952
		internal static int __PropertyOffset_bSimulatePhysics;

		// Token: 0x04013851 RID: 79953
		internal static byte __PropertyMask_bSimulatePhysics;

		// Token: 0x04013852 RID: 79954
		internal static int __PropertyOffset_bOverrideMass;

		// Token: 0x04013853 RID: 79955
		internal static byte __PropertyMask_bOverrideMass;

		// Token: 0x04013854 RID: 79956
		internal static int __PropertyOffset_bEnableGravity;

		// Token: 0x04013855 RID: 79957
		internal static byte __PropertyMask_bEnableGravity;

		// Token: 0x04013856 RID: 79958
		internal static int __PropertyOffset_bAutoWeld;

		// Token: 0x04013857 RID: 79959
		internal static byte __PropertyMask_bAutoWeld;

		// Token: 0x04013858 RID: 79960
		internal static int __PropertyOffset_bStartAwake;

		// Token: 0x04013859 RID: 79961
		internal static byte __PropertyMask_bStartAwake;

		// Token: 0x0401385A RID: 79962
		internal static int __PropertyOffset_bGenerateWakeEvents;

		// Token: 0x0401385B RID: 79963
		internal static byte __PropertyMask_bGenerateWakeEvents;

		// Token: 0x0401385C RID: 79964
		internal static int __PropertyOffset_bUpdateMassWhenScaleChanges;

		// Token: 0x0401385D RID: 79965
		internal static byte __PropertyMask_bUpdateMassWhenScaleChanges;
	}
}
