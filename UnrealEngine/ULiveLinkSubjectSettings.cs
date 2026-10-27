using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200221E RID: 8734
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSubjectSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class ULiveLinkSubjectSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021431 RID: 136241 RVA: 0x003107DF File Offset: 0x0030E9DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkSubjectSettings._ClassPtr;
		}

		// Token: 0x06021432 RID: 136242 RVA: 0x003107EC File Offset: 0x0030E9EC
		public ULiveLinkSubjectSettings() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkSubjectSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021433 RID: 136243 RVA: 0x00310814 File Offset: 0x0030EA14
		public ULiveLinkSubjectSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkSubjectSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170081D3 RID: 33235
		// (get) Token: 0x06021434 RID: 136244 RVA: 0x00310848 File Offset: 0x0030EA48
		// (set) Token: 0x06021435 RID: 136245 RVA: 0x00310881 File Offset: 0x0030EA81
		public TArray<ULiveLinkFramePreProcessor> PreProcessors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULiveLinkFramePreProcessor> result;
				if ((result = this._PreProcessors) == null)
				{
					result = (this._PreProcessors = new TArray<ULiveLinkFramePreProcessor>(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_PreProcessors, this));
				}
				return result;
			}
			set
			{
				this.PreProcessors.CopyAssign(value);
			}
		}

		// Token: 0x170081D4 RID: 33236
		// (get) Token: 0x06021436 RID: 136246 RVA: 0x0031088F File Offset: 0x0030EA8F
		// (set) Token: 0x06021437 RID: 136247 RVA: 0x003108A3 File Offset: 0x0030EAA3
		[Nullable(2)]
		public unsafe ULiveLinkFrameInterpolationProcessor InterpolationProcessor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULiveLinkFrameInterpolationProcessor>(base.NativePtr / (IntPtr)sizeof(void*) + ULiveLinkSubjectSettings.__PropertyOffset_InterpolationProcessor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULiveLinkSubjectSettings.__PropertyOffset_InterpolationProcessor, value);
			}
		}

		// Token: 0x170081D5 RID: 33237
		// (get) Token: 0x06021438 RID: 136248 RVA: 0x003108B8 File Offset: 0x0030EAB8
		// (set) Token: 0x06021439 RID: 136249 RVA: 0x003108F1 File Offset: 0x0030EAF1
		public TArray<ULiveLinkFrameTranslator> Translators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULiveLinkFrameTranslator> result;
				if ((result = this._Translators) == null)
				{
					result = (this._Translators = new TArray<ULiveLinkFrameTranslator>(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_Translators, this));
				}
				return result;
			}
			set
			{
				this.Translators.CopyAssign(value);
			}
		}

		// Token: 0x170081D6 RID: 33238
		// (get) Token: 0x0602143A RID: 136250 RVA: 0x003108FF File Offset: 0x0030EAFF
		// (set) Token: 0x0602143B RID: 136251 RVA: 0x00310913 File Offset: 0x0030EB13
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ULiveLinkRole> Role
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_Role);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_Role) = value;
			}
		}

		// Token: 0x170081D7 RID: 33239
		// (get) Token: 0x0602143C RID: 136252 RVA: 0x00310928 File Offset: 0x0030EB28
		// (set) Token: 0x0602143D RID: 136253 RVA: 0x0031093C File Offset: 0x0030EB3C
		public unsafe FFrameRate FrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_FrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_FrameRate) = value;
			}
		}

		// Token: 0x170081D8 RID: 33240
		// (get) Token: 0x0602143E RID: 136254 RVA: 0x00310951 File Offset: 0x0030EB51
		// (set) Token: 0x0602143F RID: 136255 RVA: 0x00310961 File Offset: 0x0030EB61
		public unsafe bool bRebroadcastSubject
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_bRebroadcastSubject) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULiveLinkSubjectSettings.__PropertyOffset_bRebroadcastSubject) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021440 RID: 136256 RVA: 0x00310972 File Offset: 0x0030EB72
		static ULiveLinkSubjectSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkSubjectSettings");
		}

		// Token: 0x06021441 RID: 136257 RVA: 0x00310980 File Offset: 0x0030EB80
		protected ULiveLinkSubjectSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BD9 RID: 72665
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSubjectSettings";

		// Token: 0x04011BDA RID: 72666
		private static IntPtr _ClassPtr;

		// Token: 0x04011BDB RID: 72667
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BDC RID: 72668
		internal static int __PropertyOffset_PreProcessors;

		// Token: 0x04011BDD RID: 72669
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULiveLinkFramePreProcessor> _PreProcessors;

		// Token: 0x04011BDE RID: 72670
		internal static int __PropertyOffset_InterpolationProcessor;

		// Token: 0x04011BDF RID: 72671
		internal static int __PropertyOffset_Translators;

		// Token: 0x04011BE0 RID: 72672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULiveLinkFrameTranslator> _Translators;

		// Token: 0x04011BE1 RID: 72673
		internal static int __PropertyOffset_Role;

		// Token: 0x04011BE2 RID: 72674
		internal static int __PropertyOffset_FrameRate;

		// Token: 0x04011BE3 RID: 72675
		internal static int __PropertyOffset_bRebroadcastSubject;
	}
}
