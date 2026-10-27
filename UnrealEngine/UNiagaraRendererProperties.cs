using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D8 RID: 9688
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraRendererProperties")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public abstract class UNiagaraRendererProperties : UNiagaraMergeable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FF4 RID: 147444 RVA: 0x00353FBA File Offset: 0x003521BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraRendererProperties._ClassPtr;
		}

		// Token: 0x17008A6A RID: 35434
		// (get) Token: 0x06023FF5 RID: 147445 RVA: 0x00353FC8 File Offset: 0x003521C8
		// (set) Token: 0x06023FF6 RID: 147446 RVA: 0x00354001 File Offset: 0x00352201
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_Platforms, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008A6B RID: 35435
		// (get) Token: 0x06023FF7 RID: 147447 RVA: 0x00354022 File Offset: 0x00352222
		// (set) Token: 0x06023FF8 RID: 147448 RVA: 0x00354032 File Offset: 0x00352232
		public unsafe int SortOrderHint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_SortOrderHint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_SortOrderHint) = value;
			}
		}

		// Token: 0x17008A6C RID: 35436
		// (get) Token: 0x06023FF9 RID: 147449 RVA: 0x00354043 File Offset: 0x00352243
		// (set) Token: 0x06023FFA RID: 147450 RVA: 0x00354053 File Offset: 0x00352253
		public unsafe bool bIsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_bIsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_bIsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008A6D RID: 35437
		// (get) Token: 0x06023FFB RID: 147451 RVA: 0x00354064 File Offset: 0x00352264
		// (set) Token: 0x06023FFC RID: 147452 RVA: 0x00354074 File Offset: 0x00352274
		public unsafe bool bMotionBlurEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_bMotionBlurEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraRendererProperties.__PropertyOffset_bMotionBlurEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023FFD RID: 147453 RVA: 0x00354085 File Offset: 0x00352285
		static UNiagaraRendererProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraRendererProperties");
		}

		// Token: 0x06023FFE RID: 147454 RVA: 0x00354094 File Offset: 0x00352294
		protected UNiagaraRendererProperties() : this(BuiltinUtils.AllocNativeUObject(UNiagaraRendererProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FFF RID: 147455 RVA: 0x003540BC File Offset: 0x003522BC
		protected UNiagaraRendererProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134D1 RID: 79057
		public new const string __ObjectPath = "/Script/Niagara.NiagaraRendererProperties";

		// Token: 0x040134D2 RID: 79058
		private static IntPtr _ClassPtr;

		// Token: 0x040134D3 RID: 79059
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134D4 RID: 79060
		internal static int __PropertyOffset_Platforms;

		// Token: 0x040134D5 RID: 79061
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;

		// Token: 0x040134D6 RID: 79062
		internal static int __PropertyOffset_SortOrderHint;

		// Token: 0x040134D7 RID: 79063
		internal static int __PropertyOffset_bIsEnabled;

		// Token: 0x040134D8 RID: 79064
		internal static int __PropertyOffset_bMotionBlurEnabled;
	}
}
