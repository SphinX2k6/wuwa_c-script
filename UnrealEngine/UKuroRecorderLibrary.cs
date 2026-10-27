using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001673 RID: 5747
	[UnrealObjectPath("/Script/KuroAnim.KuroRecorderLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroRecorderLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014D9F RID: 85407 RVA: 0x001EA856 File Offset: 0x001E8A56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRecorderLibrary._ClassPtr;
		}

		// Token: 0x06014DA0 RID: 85408 RVA: 0x001EA864 File Offset: 0x001E8A64
		public UKuroRecorderLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroRecorderLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014DA1 RID: 85409 RVA: 0x001EA88C File Offset: 0x001E8A8C
		[NullableContext(1)]
		public UKuroRecorderLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRecorderLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014DA2 RID: 85410 RVA: 0x001EA8C0 File Offset: 0x001E8AC0
		[NullableContext(2)]
		public unsafe static FGuid CopyLevelSequence(ULevelSequence SourceSequence, ULevelSequence TargetSequence, float TimeOffset, TMap<FName, FGuid> RetargetAttached, [Nullable(new byte[]
		{
			2,
			1
		})] TSet<UClass> IgnoreClasses, FTransform StartTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = StartTransform;
			return UKuroRecorderLibrary.__CopyLevelSequence_Internal((SourceSequence != null) ? SourceSequence.NativePtr : IntPtr.Zero, (TargetSequence != null) ? TargetSequence.NativePtr : IntPtr.Zero, TimeOffset, (RetargetAttached ?? new TMap<FName, FGuid>()).NativeMapPtr, (IgnoreClasses ?? new TSet<UClass>()).NativeSetPtr, ptr);
		}

		// Token: 0x06014DA3 RID: 85411 RVA: 0x001EA92B File Offset: 0x001E8B2B
		[NullableContext(2)]
		public static void ChangeAttachTrack(ULevelSequence TargetSequence, FGuid From, FGuid To, float Time)
		{
			UKuroRecorderLibrary.__ChangeAttachTrack_Internal((TargetSequence != null) ? TargetSequence.NativePtr : IntPtr.Zero, From, To, Time);
		}

		// Token: 0x06014DA4 RID: 85412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __CopyLevelSequence_Internal(IntPtr SourceSequence, IntPtr TargetSequence, float TimeOffset, IntPtr RetargetAttached, IntPtr IgnoreClasses, in FTransform StartTransform);

		// Token: 0x06014DA5 RID: 85413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeAttachTrack_Internal(IntPtr TargetSequence, FGuid From, FGuid To, float Time);

		// Token: 0x06014DA6 RID: 85414 RVA: 0x001EA945 File Offset: 0x001E8B45
		static UKuroRecorderLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroRecorderLibrary");
		}

		// Token: 0x06014DA7 RID: 85415 RVA: 0x001EA953 File Offset: 0x001E8B53
		protected UKuroRecorderLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B5D4 RID: 46548
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroRecorderLibrary";

		// Token: 0x0400B5D5 RID: 46549
		private static IntPtr _ClassPtr;

		// Token: 0x0400B5D6 RID: 46550
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
