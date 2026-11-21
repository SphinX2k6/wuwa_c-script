using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000300 RID: 768
	[UnrealObjectPath("/Script/KuroAnim.KuroRecorderLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroRecorderLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060052CD RID: 21197 RVA: 0x00073C12 File Offset: 0x00071E12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRecorderLibrary._ClassPtr;
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00073C20 File Offset: 0x00071E20
		public UKuroRecorderLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroRecorderLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00073C48 File Offset: 0x00071E48
		[NullableContext(1)]
		public UKuroRecorderLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRecorderLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00073C7B File Offset: 0x00071E7B
		[NullableContext(2)]
		public static void FixTrackRowIndices(ULevelSequence TargetSequence)
		{
			UKuroRecorderLibrary.__FixTrackRowIndices_Internal((TargetSequence != null) ? TargetSequence.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00073C94 File Offset: 0x00071E94
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

		// Token: 0x060052D2 RID: 21202 RVA: 0x00073CFF File Offset: 0x00071EFF
		[NullableContext(2)]
		public static void ChangeAttachTrack(ULevelSequence TargetSequence, FGuid From, FGuid To, float Time)
		{
			UKuroRecorderLibrary.__ChangeAttachTrack_Internal((TargetSequence != null) ? TargetSequence.NativePtr : IntPtr.Zero, From, To, Time);
		}

		// Token: 0x060052D3 RID: 21203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FixTrackRowIndices_Internal(IntPtr TargetSequence);

		// Token: 0x060052D4 RID: 21204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __CopyLevelSequence_Internal(IntPtr SourceSequence, IntPtr TargetSequence, float TimeOffset, IntPtr RetargetAttached, IntPtr IgnoreClasses, in FTransform StartTransform);

		// Token: 0x060052D5 RID: 21205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeAttachTrack_Internal(IntPtr TargetSequence, FGuid From, FGuid To, float Time);

		// Token: 0x060052D6 RID: 21206 RVA: 0x00073D19 File Offset: 0x00071F19
		static UKuroRecorderLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroRecorderLibrary");
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00073D27 File Offset: 0x00071F27
		protected UKuroRecorderLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021C4 RID: 8644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroRecorderLibrary";

		// Token: 0x040021C5 RID: 8645
		private static IntPtr _ClassPtr;

		// Token: 0x040021C6 RID: 8646
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
