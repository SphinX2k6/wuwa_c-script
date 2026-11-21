using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000310 RID: 784
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioDelegates")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAudioDelegates : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600535A RID: 21338 RVA: 0x00074941 File Offset: 0x00072B41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioDelegates._ClassPtr;
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00074950 File Offset: 0x00072B50
		public UKuroAudioDelegates() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioDelegates.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00074978 File Offset: 0x00072B78
		[NullableContext(1)]
		public UKuroAudioDelegates(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioDelegates.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600535D RID: 21341
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindAudioResumeDelegate();

		// Token: 0x0600535E RID: 21342
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindAudioPauseDelegate();

		// Token: 0x0600535F RID: 21343 RVA: 0x000749AB File Offset: 0x00072BAB
		[NullableContext(2)]
		public static void SetAudioResumeDelegate(in FKuroAudioResumeDelegate InDelegate)
		{
			FKuroAudioResumeDelegate fkuroAudioResumeDelegate = InDelegate;
			UKuroAudioDelegates.__SetAudioResumeDelegate_Internal((fkuroAudioResumeDelegate != null) ? fkuroAudioResumeDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x000749C1 File Offset: 0x00072BC1
		[NullableContext(2)]
		public static void SetAudioPauseDelegate(in FKuroAudioPauseDelegate InDelegate)
		{
			FKuroAudioPauseDelegate fkuroAudioPauseDelegate = InDelegate;
			UKuroAudioDelegates.__SetAudioPauseDelegate_Internal((fkuroAudioPauseDelegate != null) ? fkuroAudioPauseDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06005361 RID: 21345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioResumeDelegate_Internal(IntPtr InDelegate);

		// Token: 0x06005362 RID: 21346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioPauseDelegate_Internal(IntPtr InDelegate);

		// Token: 0x06005363 RID: 21347 RVA: 0x000749D7 File Offset: 0x00072BD7
		static UKuroAudioDelegates()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioDelegates");
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x000749E5 File Offset: 0x00072BE5
		protected UKuroAudioDelegates(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400221C RID: 8732
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioDelegates";

		// Token: 0x0400221D RID: 8733
		private static IntPtr _ClassPtr;

		// Token: 0x0400221E RID: 8734
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
