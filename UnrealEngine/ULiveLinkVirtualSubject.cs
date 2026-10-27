using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002232 RID: 8754
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkVirtualSubject")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class ULiveLinkVirtualSubject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602152D RID: 136493 RVA: 0x00311C01 File Offset: 0x0030FE01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkVirtualSubject._ClassPtr;
		}

		// Token: 0x17008208 RID: 33288
		// (get) Token: 0x0602152E RID: 136494 RVA: 0x00311C0D File Offset: 0x0030FE0D
		// (set) Token: 0x0602152F RID: 136495 RVA: 0x00311C21 File Offset: 0x0030FE21
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
				return *(base.NativePtr + (IntPtr)ULiveLinkVirtualSubject.__PropertyOffset_Role);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULiveLinkVirtualSubject.__PropertyOffset_Role) = value;
			}
		}

		// Token: 0x17008209 RID: 33289
		// (get) Token: 0x06021530 RID: 136496 RVA: 0x00311C38 File Offset: 0x0030FE38
		// (set) Token: 0x06021531 RID: 136497 RVA: 0x00311C71 File Offset: 0x0030FE71
		public TArray<FLiveLinkSubjectName> Subjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkSubjectName> result;
				if ((result = this._Subjects) == null)
				{
					result = (this._Subjects = new TArray<FLiveLinkSubjectName>(base.NativePtr + (IntPtr)ULiveLinkVirtualSubject.__PropertyOffset_Subjects, this));
				}
				return result;
			}
			set
			{
				this.Subjects.CopyAssign(value);
			}
		}

		// Token: 0x1700820A RID: 33290
		// (get) Token: 0x06021532 RID: 136498 RVA: 0x00311C80 File Offset: 0x0030FE80
		// (set) Token: 0x06021533 RID: 136499 RVA: 0x00311CB9 File Offset: 0x0030FEB9
		public TArray<ULiveLinkFrameTranslator> FrameTranslators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULiveLinkFrameTranslator> result;
				if ((result = this._FrameTranslators) == null)
				{
					result = (this._FrameTranslators = new TArray<ULiveLinkFrameTranslator>(base.NativePtr + (IntPtr)ULiveLinkVirtualSubject.__PropertyOffset_FrameTranslators, this));
				}
				return result;
			}
			set
			{
				this.FrameTranslators.CopyAssign(value);
			}
		}

		// Token: 0x06021534 RID: 136500 RVA: 0x00311CC7 File Offset: 0x0030FEC7
		static ULiveLinkVirtualSubject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkVirtualSubject");
		}

		// Token: 0x06021535 RID: 136501 RVA: 0x00311CD8 File Offset: 0x0030FED8
		protected ULiveLinkVirtualSubject() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkVirtualSubject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021536 RID: 136502 RVA: 0x00311D00 File Offset: 0x0030FF00
		protected ULiveLinkVirtualSubject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C46 RID: 72774
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkVirtualSubject";

		// Token: 0x04011C47 RID: 72775
		private static IntPtr _ClassPtr;

		// Token: 0x04011C48 RID: 72776
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C49 RID: 72777
		internal static int __PropertyOffset_Role;

		// Token: 0x04011C4A RID: 72778
		internal static int __PropertyOffset_Subjects;

		// Token: 0x04011C4B RID: 72779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkSubjectName> _Subjects;

		// Token: 0x04011C4C RID: 72780
		internal static int __PropertyOffset_FrameTranslators;

		// Token: 0x04011C4D RID: 72781
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULiveLinkFrameTranslator> _FrameTranslators;
	}
}
