using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C6 RID: 10694
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.RetainerBox")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class URetainerBox : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027873 RID: 161907 RVA: 0x003C51BE File Offset: 0x003C33BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URetainerBox._ClassPtr;
		}

		// Token: 0x06027874 RID: 161908 RVA: 0x003C51CC File Offset: 0x003C33CC
		public URetainerBox() : this(BuiltinUtils.AllocNativeUObject(URetainerBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027875 RID: 161909 RVA: 0x003C51F4 File Offset: 0x003C33F4
		[NullableContext(1)]
		public URetainerBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URetainerBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700977E RID: 38782
		// (get) Token: 0x06027876 RID: 161910 RVA: 0x003C5227 File Offset: 0x003C3427
		// (set) Token: 0x06027877 RID: 161911 RVA: 0x003C5237 File Offset: 0x003C3437
		public unsafe bool bRetainRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_bRetainRender) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_bRetainRender) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700977F RID: 38783
		// (get) Token: 0x06027878 RID: 161912 RVA: 0x003C5248 File Offset: 0x003C3448
		// (set) Token: 0x06027879 RID: 161913 RVA: 0x003C5258 File Offset: 0x003C3458
		public unsafe bool RenderOnInvalidation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_RenderOnInvalidation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_RenderOnInvalidation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009780 RID: 38784
		// (get) Token: 0x0602787A RID: 161914 RVA: 0x003C5269 File Offset: 0x003C3469
		// (set) Token: 0x0602787B RID: 161915 RVA: 0x003C5279 File Offset: 0x003C3479
		public unsafe bool RenderOnPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_RenderOnPhase) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_RenderOnPhase) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009781 RID: 38785
		// (get) Token: 0x0602787C RID: 161916 RVA: 0x003C528A File Offset: 0x003C348A
		// (set) Token: 0x0602787D RID: 161917 RVA: 0x003C529A File Offset: 0x003C349A
		public unsafe int Phase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_Phase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_Phase) = value;
			}
		}

		// Token: 0x17009782 RID: 38786
		// (get) Token: 0x0602787E RID: 161918 RVA: 0x003C52AB File Offset: 0x003C34AB
		// (set) Token: 0x0602787F RID: 161919 RVA: 0x003C52BB File Offset: 0x003C34BB
		public unsafe int PhaseCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_PhaseCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_PhaseCount) = value;
			}
		}

		// Token: 0x17009783 RID: 38787
		// (get) Token: 0x06027880 RID: 161920 RVA: 0x003C52CC File Offset: 0x003C34CC
		// (set) Token: 0x06027881 RID: 161921 RVA: 0x003C52E0 File Offset: 0x003C34E0
		public unsafe UMaterialInterface EffectMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + URetainerBox.__PropertyOffset_EffectMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URetainerBox.__PropertyOffset_EffectMaterial, value);
			}
		}

		// Token: 0x17009784 RID: 38788
		// (get) Token: 0x06027882 RID: 161922 RVA: 0x003C52F5 File Offset: 0x003C34F5
		// (set) Token: 0x06027883 RID: 161923 RVA: 0x003C5309 File Offset: 0x003C3509
		public unsafe FName TextureParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_TextureParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URetainerBox.__PropertyOffset_TextureParameter) = value;
			}
		}

		// Token: 0x06027884 RID: 161924 RVA: 0x003C531E File Offset: 0x003C351E
		public void SetTextureParameter(FName TextureParameter)
		{
			URetainerBox.__SetTextureParameter_Internal(base.NativePtr, TextureParameter);
		}

		// Token: 0x06027885 RID: 161925 RVA: 0x003C532C File Offset: 0x003C352C
		public void SetRetainRendering(bool bInRetainRendering)
		{
			URetainerBox.__SetRetainRendering_Internal(base.NativePtr, bInRetainRendering);
		}

		// Token: 0x06027886 RID: 161926 RVA: 0x003C533A File Offset: 0x003C353A
		public void SetRenderingPhase(int RenderPhase, int TotalPhases)
		{
			URetainerBox.__SetRenderingPhase_Internal(base.NativePtr, RenderPhase, TotalPhases);
		}

		// Token: 0x06027887 RID: 161927 RVA: 0x003C5349 File Offset: 0x003C3549
		public void SetEffectMaterial(UMaterialInterface EffectMaterial)
		{
			URetainerBox.__SetEffectMaterial_Internal(base.NativePtr, (EffectMaterial != null) ? EffectMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027888 RID: 161928 RVA: 0x003C5366 File Offset: 0x003C3566
		public void RequestRender()
		{
			URetainerBox.__RequestRender_Internal(base.NativePtr);
		}

		// Token: 0x06027889 RID: 161929 RVA: 0x003C5373 File Offset: 0x003C3573
		public UMaterialInstanceDynamic GetEffectMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(URetainerBox.__GetEffectMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0602788A RID: 161930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureParameter_Internal(IntPtr @this, FName TextureParameter);

		// Token: 0x0602788B RID: 161931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRetainRendering_Internal(IntPtr @this, bool bInRetainRendering);

		// Token: 0x0602788C RID: 161932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderingPhase_Internal(IntPtr @this, int RenderPhase, int TotalPhases);

		// Token: 0x0602788D RID: 161933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectMaterial_Internal(IntPtr @this, IntPtr EffectMaterial);

		// Token: 0x0602788E RID: 161934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestRender_Internal(IntPtr @this);

		// Token: 0x0602788F RID: 161935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEffectMaterial_Internal(IntPtr @this);

		// Token: 0x06027890 RID: 161936 RVA: 0x003C5385 File Offset: 0x003C3585
		static URetainerBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.RetainerBox");
		}

		// Token: 0x06027891 RID: 161937 RVA: 0x003C5393 File Offset: 0x003C3593
		protected URetainerBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AC1 RID: 88769
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.RetainerBox";

		// Token: 0x04015AC2 RID: 88770
		private static IntPtr _ClassPtr;

		// Token: 0x04015AC3 RID: 88771
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AC4 RID: 88772
		internal static int __PropertyOffset_bRetainRender;

		// Token: 0x04015AC5 RID: 88773
		internal static int __PropertyOffset_RenderOnInvalidation;

		// Token: 0x04015AC6 RID: 88774
		internal static int __PropertyOffset_RenderOnPhase;

		// Token: 0x04015AC7 RID: 88775
		internal static int __PropertyOffset_Phase;

		// Token: 0x04015AC8 RID: 88776
		internal static int __PropertyOffset_PhaseCount;

		// Token: 0x04015AC9 RID: 88777
		internal static int __PropertyOffset_EffectMaterial;

		// Token: 0x04015ACA RID: 88778
		internal static int __PropertyOffset_TextureParameter;
	}
}
