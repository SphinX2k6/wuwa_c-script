using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002909 RID: 10505
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequencePlayer")]
	[UnrealStructLayout(1824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1824)]
	public class UTemplateSequencePlayer : UMovieSceneSequencePlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F74 RID: 159604 RVA: 0x003B6DC1 File Offset: 0x003B4FC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTemplateSequencePlayer._ClassPtr;
		}

		// Token: 0x06026F75 RID: 159605 RVA: 0x003B6DD0 File Offset: 0x003B4FD0
		public UTemplateSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(UTemplateSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F76 RID: 159606 RVA: 0x003B6DF8 File Offset: 0x003B4FF8
		[NullableContext(1)]
		public UTemplateSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTemplateSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026F77 RID: 159607 RVA: 0x003B6E2C File Offset: 0x003B502C
		[NullableContext(2)]
		public static UTemplateSequencePlayer CreateTemplateSequencePlayer(UObject WorldContextObject, UTemplateSequence TemplateSequence, FMovieSceneSequencePlaybackSettings Settings, ref ATemplateSequenceActor OutActor)
		{
			ATemplateSequenceActor atemplateSequenceActor = OutActor;
			IntPtr nativeObjectPtr = (atemplateSequenceActor != null) ? atemplateSequenceActor.NativePtr : IntPtr.Zero;
			UTemplateSequencePlayer orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTemplateSequencePlayer>(UTemplateSequencePlayer.__CreateTemplateSequencePlayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TemplateSequence != null) ? TemplateSequence.NativePtr : IntPtr.Zero, (Settings ?? new FMovieSceneSequencePlaybackSettings()).NativePtr, ref nativeObjectPtr));
			OutActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<ATemplateSequenceActor>(nativeObjectPtr);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06026F78 RID: 159608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTemplateSequencePlayer_Internal(IntPtr WorldContextObject, IntPtr TemplateSequence, IntPtr Settings, ref IntPtr OutActor);

		// Token: 0x06026F79 RID: 159609 RVA: 0x003B6E8F File Offset: 0x003B508F
		static UTemplateSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.TemplateSequencePlayer");
		}

		// Token: 0x06026F7A RID: 159610 RVA: 0x003B6E9D File Offset: 0x003B509D
		protected UTemplateSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015627 RID: 87591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.TemplateSequencePlayer";

		// Token: 0x04015628 RID: 87592
		private static IntPtr _ClassPtr;

		// Token: 0x04015629 RID: 87593
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
