using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001696 RID: 5782
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioDelegates")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAudioDelegates : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F78 RID: 85880 RVA: 0x001ED21B File Offset: 0x001EB41B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioDelegates._ClassPtr;
		}

		// Token: 0x06014F79 RID: 85881 RVA: 0x001ED228 File Offset: 0x001EB428
		public UKuroAudioDelegates() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioDelegates.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F7A RID: 85882 RVA: 0x001ED250 File Offset: 0x001EB450
		[NullableContext(1)]
		public UKuroAudioDelegates(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioDelegates.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014F7B RID: 85883
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindAudioResumeDelegate();

		// Token: 0x06014F7C RID: 85884
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindAudioPauseDelegate();

		// Token: 0x06014F7D RID: 85885 RVA: 0x001ED283 File Offset: 0x001EB483
		[NullableContext(2)]
		public static void SetAudioResumeDelegate(in FKuroAudioResumeDelegate InDelegate)
		{
			FKuroAudioResumeDelegate fkuroAudioResumeDelegate = InDelegate;
			UKuroAudioDelegates.__SetAudioResumeDelegate_Internal((fkuroAudioResumeDelegate != null) ? fkuroAudioResumeDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06014F7E RID: 85886 RVA: 0x001ED299 File Offset: 0x001EB499
		[NullableContext(2)]
		public static void SetAudioPauseDelegate(in FKuroAudioPauseDelegate InDelegate)
		{
			FKuroAudioPauseDelegate fkuroAudioPauseDelegate = InDelegate;
			UKuroAudioDelegates.__SetAudioPauseDelegate_Internal((fkuroAudioPauseDelegate != null) ? fkuroAudioPauseDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06014F7F RID: 85887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioResumeDelegate_Internal(IntPtr InDelegate);

		// Token: 0x06014F80 RID: 85888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioPauseDelegate_Internal(IntPtr InDelegate);

		// Token: 0x06014F81 RID: 85889 RVA: 0x001ED2AF File Offset: 0x001EB4AF
		static UKuroAudioDelegates()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioDelegates");
		}

		// Token: 0x06014F82 RID: 85890 RVA: 0x001ED2BD File Offset: 0x001EB4BD
		protected UKuroAudioDelegates(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6CA RID: 46794
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioDelegates";

		// Token: 0x0400B6CB RID: 46795
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6CC RID: 46796
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
