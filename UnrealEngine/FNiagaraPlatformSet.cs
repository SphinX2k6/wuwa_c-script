using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025C8 RID: 9672
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraPlatformSet")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraPlatformSet : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023F37 RID: 147255 RVA: 0x00352C97 File Offset: 0x00350E97
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraPlatformSet._ScriptStructPtr != 0) ? FNiagaraPlatformSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraPlatformSet", ref FNiagaraPlatformSet._ScriptStructPtr);
		}

		// Token: 0x17008A3E RID: 35390
		// (get) Token: 0x06023F38 RID: 147256 RVA: 0x00352CBB File Offset: 0x00350EBB
		// (set) Token: 0x06023F39 RID: 147257 RVA: 0x00352CCB File Offset: 0x00350ECB
		public unsafe int QualityLevelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraPlatformSet.__PropertyOffset_QualityLevelMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraPlatformSet.__PropertyOffset_QualityLevelMask) = value;
			}
		}

		// Token: 0x17008A3F RID: 35391
		// (get) Token: 0x06023F3A RID: 147258 RVA: 0x00352CDC File Offset: 0x00350EDC
		// (set) Token: 0x06023F3B RID: 147259 RVA: 0x00352D1F File Offset: 0x00350F1F
		public TArray<FNiagaraDeviceProfileStateEntry> DeviceProfileStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraDeviceProfileStateEntry> result;
				if ((result = this._DeviceProfileStates) == null)
				{
					result = (this._DeviceProfileStates = new TArray<FNiagaraDeviceProfileStateEntry>(base.NativePtr + (IntPtr)FNiagaraPlatformSet.__PropertyOffset_DeviceProfileStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DeviceProfileStates.CopyAssign(value);
			}
		}

		// Token: 0x17008A40 RID: 35392
		// (get) Token: 0x06023F3C RID: 147260 RVA: 0x00352D30 File Offset: 0x00350F30
		// (set) Token: 0x06023F3D RID: 147261 RVA: 0x00352D73 File Offset: 0x00350F73
		public TArray<FNiagaraPlatformSetCVarCondition> CVarConditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraPlatformSetCVarCondition> result;
				if ((result = this._CVarConditions) == null)
				{
					result = (this._CVarConditions = new TArray<FNiagaraPlatformSetCVarCondition>(base.NativePtr + (IntPtr)FNiagaraPlatformSet.__PropertyOffset_CVarConditions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CVarConditions.CopyAssign(value);
			}
		}

		// Token: 0x06023F3E RID: 147262 RVA: 0x00352D81 File Offset: 0x00350F81
		public FNiagaraPlatformSet()
		{
		}

		// Token: 0x06023F3F RID: 147263 RVA: 0x00352D89 File Offset: 0x00350F89
		public FNiagaraPlatformSet(int QualityLevelMask, TArray<FNiagaraDeviceProfileStateEntry> DeviceProfileStates, TArray<FNiagaraPlatformSetCVarCondition> CVarConditions)
		{
			this.QualityLevelMask = QualityLevelMask;
			this.DeviceProfileStates = DeviceProfileStates;
			this.CVarConditions = CVarConditions;
		}

		// Token: 0x06023F40 RID: 147264 RVA: 0x00352DA6 File Offset: 0x00350FA6
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraPlatformSet.StaticStruct();
		}

		// Token: 0x06023F41 RID: 147265 RVA: 0x00352DB2 File Offset: 0x00350FB2
		[NullableContext(2)]
		public FNiagaraPlatformSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023F42 RID: 147266 RVA: 0x00352DBC File Offset: 0x00350FBC
		public FNiagaraPlatformSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023F43 RID: 147267 RVA: 0x00352DC7 File Offset: 0x00350FC7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraPlatformSet(Pointer, false, true);
		}

		// Token: 0x06023F44 RID: 147268 RVA: 0x00352DD1 File Offset: 0x00350FD1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraPlatformSet(Pointer, MemoryOwner);
		}

		// Token: 0x04013466 RID: 78950
		public const string __ObjectPath = "/Script/Niagara.NiagaraPlatformSet";

		// Token: 0x04013467 RID: 78951
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013468 RID: 78952
		internal static int __PropertyOffset_QualityLevelMask;

		// Token: 0x04013469 RID: 78953
		internal static int __PropertyOffset_DeviceProfileStates;

		// Token: 0x0401346A RID: 78954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraDeviceProfileStateEntry> _DeviceProfileStates;

		// Token: 0x0401346B RID: 78955
		internal static int __PropertyOffset_CVarConditions;

		// Token: 0x0401346C RID: 78956
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraPlatformSetCVarCondition> _CVarConditions;
	}
}
