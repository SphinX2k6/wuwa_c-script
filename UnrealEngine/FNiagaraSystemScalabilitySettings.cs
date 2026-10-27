using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025F4 RID: 9716
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemScalabilitySettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNiagaraSystemScalabilitySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024243 RID: 148035 RVA: 0x00357F08 File Offset: 0x00356108
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemScalabilitySettings._ScriptStructPtr != 0) ? FNiagaraSystemScalabilitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemScalabilitySettings", ref FNiagaraSystemScalabilitySettings._ScriptStructPtr);
		}

		// Token: 0x17008B34 RID: 35636
		// (get) Token: 0x06024244 RID: 148036 RVA: 0x00357F2C File Offset: 0x0035612C
		// (set) Token: 0x06024245 RID: 148037 RVA: 0x00357F6F File Offset: 0x0035616F
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_Platforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B35 RID: 35637
		// (get) Token: 0x06024246 RID: 148038 RVA: 0x00357F90 File Offset: 0x00356190
		// (set) Token: 0x06024247 RID: 148039 RVA: 0x00357FA9 File Offset: 0x003561A9
		public unsafe bool bCullByDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullByDistance) & FNiagaraSystemScalabilitySettings.__PropertyMask_bCullByDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullByDistance) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullByDistance) & ~FNiagaraSystemScalabilitySettings.__PropertyMask_bCullByDistance) | (value ? FNiagaraSystemScalabilitySettings.__PropertyMask_bCullByDistance : 0));
			}
		}

		// Token: 0x17008B36 RID: 35638
		// (get) Token: 0x06024248 RID: 148040 RVA: 0x00357FD9 File Offset: 0x003561D9
		// (set) Token: 0x06024249 RID: 148041 RVA: 0x00357FF2 File Offset: 0x003561F2
		public unsafe bool bCullMaxInstanceCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullMaxInstanceCount) & FNiagaraSystemScalabilitySettings.__PropertyMask_bCullMaxInstanceCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullMaxInstanceCount) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullMaxInstanceCount) & ~FNiagaraSystemScalabilitySettings.__PropertyMask_bCullMaxInstanceCount) | (value ? FNiagaraSystemScalabilitySettings.__PropertyMask_bCullMaxInstanceCount : 0));
			}
		}

		// Token: 0x17008B37 RID: 35639
		// (get) Token: 0x0602424A RID: 148042 RVA: 0x00358022 File Offset: 0x00356222
		// (set) Token: 0x0602424B RID: 148043 RVA: 0x0035803B File Offset: 0x0035623B
		public unsafe bool bCullPerSystemMaxInstanceCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullPerSystemMaxInstanceCount) & FNiagaraSystemScalabilitySettings.__PropertyMask_bCullPerSystemMaxInstanceCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullPerSystemMaxInstanceCount) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullPerSystemMaxInstanceCount) & ~FNiagaraSystemScalabilitySettings.__PropertyMask_bCullPerSystemMaxInstanceCount) | (value ? FNiagaraSystemScalabilitySettings.__PropertyMask_bCullPerSystemMaxInstanceCount : 0));
			}
		}

		// Token: 0x17008B38 RID: 35640
		// (get) Token: 0x0602424C RID: 148044 RVA: 0x0035806B File Offset: 0x0035626B
		// (set) Token: 0x0602424D RID: 148045 RVA: 0x00358084 File Offset: 0x00356284
		public unsafe bool bCullByMaxTimeWithoutRender
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullByMaxTimeWithoutRender) & FNiagaraSystemScalabilitySettings.__PropertyMask_bCullByMaxTimeWithoutRender) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullByMaxTimeWithoutRender) = ((*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_bCullByMaxTimeWithoutRender) & ~FNiagaraSystemScalabilitySettings.__PropertyMask_bCullByMaxTimeWithoutRender) | (value ? FNiagaraSystemScalabilitySettings.__PropertyMask_bCullByMaxTimeWithoutRender : 0));
			}
		}

		// Token: 0x17008B39 RID: 35641
		// (get) Token: 0x0602424E RID: 148046 RVA: 0x003580B4 File Offset: 0x003562B4
		// (set) Token: 0x0602424F RID: 148047 RVA: 0x003580C4 File Offset: 0x003562C4
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17008B3A RID: 35642
		// (get) Token: 0x06024250 RID: 148048 RVA: 0x003580D5 File Offset: 0x003562D5
		// (set) Token: 0x06024251 RID: 148049 RVA: 0x003580E5 File Offset: 0x003562E5
		public unsafe int MaxInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxInstances) = value;
			}
		}

		// Token: 0x17008B3B RID: 35643
		// (get) Token: 0x06024252 RID: 148050 RVA: 0x003580F6 File Offset: 0x003562F6
		// (set) Token: 0x06024253 RID: 148051 RVA: 0x00358106 File Offset: 0x00356306
		public unsafe int MaxSystemInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxSystemInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxSystemInstances) = value;
			}
		}

		// Token: 0x17008B3C RID: 35644
		// (get) Token: 0x06024254 RID: 148052 RVA: 0x00358117 File Offset: 0x00356317
		// (set) Token: 0x06024255 RID: 148053 RVA: 0x00358127 File Offset: 0x00356327
		public unsafe float MaxTimeWithoutRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxTimeWithoutRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraSystemScalabilitySettings.__PropertyOffset_MaxTimeWithoutRender) = value;
			}
		}

		// Token: 0x06024256 RID: 148054 RVA: 0x00358138 File Offset: 0x00356338
		public FNiagaraSystemScalabilitySettings()
		{
		}

		// Token: 0x06024257 RID: 148055 RVA: 0x00358140 File Offset: 0x00356340
		public FNiagaraSystemScalabilitySettings(FNiagaraPlatformSet Platforms, bool bCullByDistance, bool bCullMaxInstanceCount, bool bCullPerSystemMaxInstanceCount, bool bCullByMaxTimeWithoutRender, float MaxDistance, int MaxInstances, int MaxSystemInstances, float MaxTimeWithoutRender)
		{
			this.Platforms = Platforms;
			this.bCullByDistance = bCullByDistance;
			this.bCullMaxInstanceCount = bCullMaxInstanceCount;
			this.bCullPerSystemMaxInstanceCount = bCullPerSystemMaxInstanceCount;
			this.bCullByMaxTimeWithoutRender = bCullByMaxTimeWithoutRender;
			this.MaxDistance = MaxDistance;
			this.MaxInstances = MaxInstances;
			this.MaxSystemInstances = MaxSystemInstances;
			this.MaxTimeWithoutRender = MaxTimeWithoutRender;
		}

		// Token: 0x06024258 RID: 148056 RVA: 0x00358198 File Offset: 0x00356398
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemScalabilitySettings.StaticStruct();
		}

		// Token: 0x06024259 RID: 148057 RVA: 0x003581A4 File Offset: 0x003563A4
		[NullableContext(2)]
		public FNiagaraSystemScalabilitySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602425A RID: 148058 RVA: 0x003581AE File Offset: 0x003563AE
		public FNiagaraSystemScalabilitySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602425B RID: 148059 RVA: 0x003581B9 File Offset: 0x003563B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemScalabilitySettings(Pointer, false, true);
		}

		// Token: 0x0602425C RID: 148060 RVA: 0x003581C3 File Offset: 0x003563C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemScalabilitySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04013649 RID: 79433
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemScalabilitySettings";

		// Token: 0x0401364A RID: 79434
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401364B RID: 79435
		internal static int __PropertyOffset_Platforms;

		// Token: 0x0401364C RID: 79436
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;

		// Token: 0x0401364D RID: 79437
		internal static int __PropertyOffset_bCullByDistance;

		// Token: 0x0401364E RID: 79438
		internal static byte __PropertyMask_bCullByDistance;

		// Token: 0x0401364F RID: 79439
		internal static int __PropertyOffset_bCullMaxInstanceCount;

		// Token: 0x04013650 RID: 79440
		internal static byte __PropertyMask_bCullMaxInstanceCount;

		// Token: 0x04013651 RID: 79441
		internal static int __PropertyOffset_bCullPerSystemMaxInstanceCount;

		// Token: 0x04013652 RID: 79442
		internal static byte __PropertyMask_bCullPerSystemMaxInstanceCount;

		// Token: 0x04013653 RID: 79443
		internal static int __PropertyOffset_bCullByMaxTimeWithoutRender;

		// Token: 0x04013654 RID: 79444
		internal static byte __PropertyMask_bCullByMaxTimeWithoutRender;

		// Token: 0x04013655 RID: 79445
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x04013656 RID: 79446
		internal static int __PropertyOffset_MaxInstances;

		// Token: 0x04013657 RID: 79447
		internal static int __PropertyOffset_MaxSystemInstances;

		// Token: 0x04013658 RID: 79448
		internal static int __PropertyOffset_MaxTimeWithoutRender;
	}
}
