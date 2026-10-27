using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D8 RID: 216
	[UnrealObjectPath("/Script/ActorSequence.ActorSequencePlayer")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public class UActorSequencePlayer : UMovieSceneSequencePlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x0001A39C File Offset: 0x0001859C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorSequencePlayer._ClassPtr;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0001A3A8 File Offset: 0x000185A8
		public UActorSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(UActorSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[NullableContext(1)]
		public UActorSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0001A403 File Offset: 0x00018603
		static UActorSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ActorSequence.ActorSequencePlayer");
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0001A411 File Offset: 0x00018611
		protected UActorSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002C5 RID: 709
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ActorSequence.ActorSequencePlayer";

		// Token: 0x040002C6 RID: 710
		private static IntPtr _ClassPtr;

		// Token: 0x040002C7 RID: 711
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
