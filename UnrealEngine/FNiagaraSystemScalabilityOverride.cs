using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F2 RID: 9714
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemScalabilityOverride")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FNiagaraSystemScalabilityOverride : FNiagaraSystemScalabilitySettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024229 RID: 148009 RVA: 0x00357C4C File Offset: 0x00355E4C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemScalabilityOverride._ScriptStructPtr != 0) ? FNiagaraSystemScalabilityOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemScalabilityOverride", ref FNiagaraSystemScalabilityOverride._ScriptStructPtr);
		}

		// Token: 0x17008B2F RID: 35631
		// (get) Token: 0x0602422A RID: 148010 RVA: 0x00357C70 File Offset: 0x00355E70
		// (set) Token: 0x0602422B RID: 148011 RVA: 0x00357C89 File Offset: 0x00355E89
		public unsafe bool bOverrideDistanceSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideDistanceSettings) & FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideDistanceSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideDistanceSettings) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideDistanceSettings) & ~FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideDistanceSettings) | (value ? FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideDistanceSettings : 0));
			}
		}

		// Token: 0x17008B30 RID: 35632
		// (get) Token: 0x0602422C RID: 148012 RVA: 0x00357CB9 File Offset: 0x00355EB9
		// (set) Token: 0x0602422D RID: 148013 RVA: 0x00357CD2 File Offset: 0x00355ED2
		public unsafe bool bOverrideInstanceCountSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideInstanceCountSettings) & FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideInstanceCountSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideInstanceCountSettings) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideInstanceCountSettings) & ~FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideInstanceCountSettings) | (value ? FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideInstanceCountSettings : 0));
			}
		}

		// Token: 0x17008B31 RID: 35633
		// (get) Token: 0x0602422E RID: 148014 RVA: 0x00357D02 File Offset: 0x00355F02
		// (set) Token: 0x0602422F RID: 148015 RVA: 0x00357D1B File Offset: 0x00355F1B
		public unsafe bool bOverridePerSystemInstanceCountSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverridePerSystemInstanceCountSettings) & FNiagaraSystemScalabilityOverride.__PropertyMask_bOverridePerSystemInstanceCountSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverridePerSystemInstanceCountSettings) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverridePerSystemInstanceCountSettings) & ~FNiagaraSystemScalabilityOverride.__PropertyMask_bOverridePerSystemInstanceCountSettings) | (value ? FNiagaraSystemScalabilityOverride.__PropertyMask_bOverridePerSystemInstanceCountSettings : 0));
			}
		}

		// Token: 0x17008B32 RID: 35634
		// (get) Token: 0x06024230 RID: 148016 RVA: 0x00357D4B File Offset: 0x00355F4B
		// (set) Token: 0x06024231 RID: 148017 RVA: 0x00357D64 File Offset: 0x00355F64
		public unsafe bool bOverrideTimeSinceRendererSettings
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideTimeSinceRendererSettings) & FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideTimeSinceRendererSettings) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideTimeSinceRendererSettings) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilityOverride.__PropertyOffset_bOverrideTimeSinceRendererSettings) & ~FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideTimeSinceRendererSettings) | (value ? FNiagaraSystemScalabilityOverride.__PropertyMask_bOverrideTimeSinceRendererSettings : 0));
			}
		}

		// Token: 0x06024232 RID: 148018 RVA: 0x00357D94 File Offset: 0x00355F94
		public FNiagaraSystemScalabilityOverride()
		{
		}

		// Token: 0x06024233 RID: 148019 RVA: 0x00357D9C File Offset: 0x00355F9C
		[NullableContext(1)]
		public FNiagaraSystemScalabilityOverride(bool bOverrideDistanceSettings, bool bOverrideInstanceCountSettings, bool bOverridePerSystemInstanceCountSettings, bool bOverrideTimeSinceRendererSettings, FNiagaraPlatformSet Platforms, bool bCullByDistance, bool bCullMaxInstanceCount, bool bCullPerSystemMaxInstanceCount, bool bCullByMaxTimeWithoutRender, float MaxDistance, int MaxInstances, int MaxSystemInstances, float MaxTimeWithoutRender)
		{
			this.bOverrideDistanceSettings = bOverrideDistanceSettings;
			this.bOverrideInstanceCountSettings = bOverrideInstanceCountSettings;
			this.bOverridePerSystemInstanceCountSettings = bOverridePerSystemInstanceCountSettings;
			this.bOverrideTimeSinceRendererSettings = bOverrideTimeSinceRendererSettings;
			base.Platforms = Platforms;
			base.bCullByDistance = bCullByDistance;
			base.bCullMaxInstanceCount = bCullMaxInstanceCount;
			base.bCullPerSystemMaxInstanceCount = bCullPerSystemMaxInstanceCount;
			base.bCullByMaxTimeWithoutRender = bCullByMaxTimeWithoutRender;
			base.MaxDistance = MaxDistance;
			base.MaxInstances = MaxInstances;
			base.MaxSystemInstances = MaxSystemInstances;
			base.MaxTimeWithoutRender = MaxTimeWithoutRender;
		}

		// Token: 0x06024234 RID: 148020 RVA: 0x00357E14 File Offset: 0x00356014
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemScalabilityOverride.StaticStruct();
		}

		// Token: 0x06024235 RID: 148021 RVA: 0x00357E20 File Offset: 0x00356020
		[NullableContext(2)]
		public FNiagaraSystemScalabilityOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024236 RID: 148022 RVA: 0x00357E2A File Offset: 0x0035602A
		public FNiagaraSystemScalabilityOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024237 RID: 148023 RVA: 0x00357E35 File Offset: 0x00356035
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemScalabilityOverride(Pointer, false, true);
		}

		// Token: 0x06024238 RID: 148024 RVA: 0x00357E3F File Offset: 0x0035603F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemScalabilityOverride(Pointer, MemoryOwner);
		}

		// Token: 0x0401363B RID: 79419
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSystemScalabilityOverride";

		// Token: 0x0401363C RID: 79420
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401363D RID: 79421
		internal static int __PropertyOffset_bOverrideDistanceSettings;

		// Token: 0x0401363E RID: 79422
		internal static byte __PropertyMask_bOverrideDistanceSettings;

		// Token: 0x0401363F RID: 79423
		internal static int __PropertyOffset_bOverrideInstanceCountSettings;

		// Token: 0x04013640 RID: 79424
		internal static byte __PropertyMask_bOverrideInstanceCountSettings;

		// Token: 0x04013641 RID: 79425
		internal static int __PropertyOffset_bOverridePerSystemInstanceCountSettings;

		// Token: 0x04013642 RID: 79426
		internal static byte __PropertyMask_bOverridePerSystemInstanceCountSettings;

		// Token: 0x04013643 RID: 79427
		internal static int __PropertyOffset_bOverrideTimeSinceRendererSettings;

		// Token: 0x04013644 RID: 79428
		internal static byte __PropertyMask_bOverrideTimeSinceRendererSettings;
	}
}
