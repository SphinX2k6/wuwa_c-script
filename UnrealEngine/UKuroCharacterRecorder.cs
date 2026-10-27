using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001661 RID: 5729
	[UnrealObjectPath("/Script/KuroAnim.KuroCharacterRecorder")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKuroCharacterRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014C07 RID: 84999 RVA: 0x001E8444 File Offset: 0x001E6644
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterRecorder._ClassPtr;
		}

		// Token: 0x06014C08 RID: 85000 RVA: 0x001E8450 File Offset: 0x001E6650
		public UKuroCharacterRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014C09 RID: 85001 RVA: 0x001E8478 File Offset: 0x001E6678
		[NullableContext(1)]
		public UKuroCharacterRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700520E RID: 21006
		// (get) Token: 0x06014C0A RID: 85002 RVA: 0x001E84AB File Offset: 0x001E66AB
		// (set) Token: 0x06014C0B RID: 85003 RVA: 0x001E84BB File Offset: 0x001E66BB
		public unsafe bool bUseClone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bUseClone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bUseClone) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700520F RID: 21007
		// (get) Token: 0x06014C0C RID: 85004 RVA: 0x001E84CC File Offset: 0x001E66CC
		// (set) Token: 0x06014C0D RID: 85005 RVA: 0x001E84DC File Offset: 0x001E66DC
		public unsafe bool bRecordSkeletalMeshAnimSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bRecordSkeletalMeshAnimSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bRecordSkeletalMeshAnimSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005210 RID: 21008
		// (get) Token: 0x06014C0E RID: 85006 RVA: 0x001E84ED File Offset: 0x001E66ED
		// (set) Token: 0x06014C0F RID: 85007 RVA: 0x001E84FD File Offset: 0x001E66FD
		public unsafe bool bComponentPossessable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bComponentPossessable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bComponentPossessable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005211 RID: 21009
		// (get) Token: 0x06014C10 RID: 85008 RVA: 0x001E850E File Offset: 0x001E670E
		// (set) Token: 0x06014C11 RID: 85009 RVA: 0x001E851E File Offset: 0x001E671E
		public unsafe bool bActorPossessable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bActorPossessable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bActorPossessable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x06014C12 RID: 85010 RVA: 0x001E852F File Offset: 0x001E672F
		// (set) Token: 0x06014C13 RID: 85011 RVA: 0x001E8543 File Offset: 0x001E6743
		[Nullable(2)]
		public unsafe UObject BaseBlueprint
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharacterRecorder.__PropertyOffset_BaseBlueprint);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharacterRecorder.__PropertyOffset_BaseBlueprint, value);
			}
		}

		// Token: 0x06014C14 RID: 85012 RVA: 0x001E8558 File Offset: 0x001E6758
		static UKuroCharacterRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroCharacterRecorder");
		}

		// Token: 0x06014C15 RID: 85013 RVA: 0x001E8566 File Offset: 0x001E6766
		protected UKuroCharacterRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B500 RID: 46336
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroCharacterRecorder";

		// Token: 0x0400B501 RID: 46337
		private static IntPtr _ClassPtr;

		// Token: 0x0400B502 RID: 46338
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B503 RID: 46339
		internal static int __PropertyOffset_bUseClone;

		// Token: 0x0400B504 RID: 46340
		internal static int __PropertyOffset_bRecordSkeletalMeshAnimSeq;

		// Token: 0x0400B505 RID: 46341
		internal static int __PropertyOffset_bComponentPossessable;

		// Token: 0x0400B506 RID: 46342
		internal static int __PropertyOffset_bActorPossessable;

		// Token: 0x0400B507 RID: 46343
		internal static int __PropertyOffset_BaseBlueprint;
	}
}
