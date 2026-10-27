using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002631 RID: 9777
	[UnrealObjectPath("/Script/PathFindModule.KuroNavigationSetting")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroNavigationSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245B8 RID: 148920 RVA: 0x0035D49E File Offset: 0x0035B69E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNavigationSetting._ClassPtr;
		}

		// Token: 0x060245B9 RID: 148921 RVA: 0x0035D4AC File Offset: 0x0035B6AC
		public UKuroNavigationSetting() : this(BuiltinUtils.AllocNativeUObject(UKuroNavigationSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245BA RID: 148922 RVA: 0x0035D4D4 File Offset: 0x0035B6D4
		[NullableContext(1)]
		public UKuroNavigationSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNavigationSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008C15 RID: 35861
		// (get) Token: 0x060245BB RID: 148923 RVA: 0x0035D507 File Offset: 0x0035B707
		// (set) Token: 0x060245BC RID: 148924 RVA: 0x0035D517 File Offset: 0x0035B717
		public unsafe int MaxPathPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxPathPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxPathPoints) = value;
			}
		}

		// Token: 0x17008C16 RID: 35862
		// (get) Token: 0x060245BD RID: 148925 RVA: 0x0035D528 File Offset: 0x0035B728
		// (set) Token: 0x060245BE RID: 148926 RVA: 0x0035D538 File Offset: 0x0035B738
		public unsafe int MaxPathPolygen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxPathPolygen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxPathPolygen) = value;
			}
		}

		// Token: 0x17008C17 RID: 35863
		// (get) Token: 0x060245BF RID: 148927 RVA: 0x0035D549 File Offset: 0x0035B749
		// (set) Token: 0x060245C0 RID: 148928 RVA: 0x0035D559 File Offset: 0x0035B759
		public unsafe float SmoothStepSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_SmoothStepSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_SmoothStepSize) = value;
			}
		}

		// Token: 0x17008C18 RID: 35864
		// (get) Token: 0x060245C1 RID: 148929 RVA: 0x0035D56A File Offset: 0x0035B76A
		// (set) Token: 0x060245C2 RID: 148930 RVA: 0x0035D57A File Offset: 0x0035B77A
		public unsafe float CloseXZRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_CloseXZRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_CloseXZRadius) = value;
			}
		}

		// Token: 0x17008C19 RID: 35865
		// (get) Token: 0x060245C3 RID: 148931 RVA: 0x0035D58B File Offset: 0x0035B78B
		// (set) Token: 0x060245C4 RID: 148932 RVA: 0x0035D59B File Offset: 0x0035B79B
		public unsafe float CloseHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_CloseHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_CloseHeight) = value;
			}
		}

		// Token: 0x17008C1A RID: 35866
		// (get) Token: 0x060245C5 RID: 148933 RVA: 0x0035D5AC File Offset: 0x0035B7AC
		// (set) Token: 0x060245C6 RID: 148934 RVA: 0x0035D5BC File Offset: 0x0035B7BC
		public unsafe float MaxOfflineHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxOfflineHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxOfflineHeight) = value;
			}
		}

		// Token: 0x17008C1B RID: 35867
		// (get) Token: 0x060245C7 RID: 148935 RVA: 0x0035D5CD File Offset: 0x0035B7CD
		// (set) Token: 0x060245C8 RID: 148936 RVA: 0x0035D5DD File Offset: 0x0035B7DD
		public unsafe float DefaultWorldHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_DefaultWorldHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_DefaultWorldHeight) = value;
			}
		}

		// Token: 0x17008C1C RID: 35868
		// (get) Token: 0x060245C9 RID: 148937 RVA: 0x0035D5EE File Offset: 0x0035B7EE
		// (set) Token: 0x060245CA RID: 148938 RVA: 0x0035D5FE File Offset: 0x0035B7FE
		public unsafe float MaxWalkableError
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxWalkableError);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_MaxWalkableError) = value;
			}
		}

		// Token: 0x17008C1D RID: 35869
		// (get) Token: 0x060245CB RID: 148939 RVA: 0x0035D60F File Offset: 0x0035B80F
		// (set) Token: 0x060245CC RID: 148940 RVA: 0x0035D623 File Offset: 0x0035B823
		public unsafe FVector FinderHalfExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_FinderHalfExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroNavigationSetting.__PropertyOffset_FinderHalfExtent) = value;
			}
		}

		// Token: 0x060245CD RID: 148941 RVA: 0x0035D638 File Offset: 0x0035B838
		static UKuroNavigationSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PathFindModule.KuroNavigationSetting");
		}

		// Token: 0x060245CE RID: 148942 RVA: 0x0035D646 File Offset: 0x0035B846
		protected UKuroNavigationSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401381C RID: 79900
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PathFindModule.KuroNavigationSetting";

		// Token: 0x0401381D RID: 79901
		private static IntPtr _ClassPtr;

		// Token: 0x0401381E RID: 79902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401381F RID: 79903
		internal static int __PropertyOffset_MaxPathPoints;

		// Token: 0x04013820 RID: 79904
		internal static int __PropertyOffset_MaxPathPolygen;

		// Token: 0x04013821 RID: 79905
		internal static int __PropertyOffset_SmoothStepSize;

		// Token: 0x04013822 RID: 79906
		internal static int __PropertyOffset_CloseXZRadius;

		// Token: 0x04013823 RID: 79907
		internal static int __PropertyOffset_CloseHeight;

		// Token: 0x04013824 RID: 79908
		internal static int __PropertyOffset_MaxOfflineHeight;

		// Token: 0x04013825 RID: 79909
		internal static int __PropertyOffset_DefaultWorldHeight;

		// Token: 0x04013826 RID: 79910
		internal static int __PropertyOffset_MaxWalkableError;

		// Token: 0x04013827 RID: 79911
		internal static int __PropertyOffset_FinderHalfExtent;
	}
}
