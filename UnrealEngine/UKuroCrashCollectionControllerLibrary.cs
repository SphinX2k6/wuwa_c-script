using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000355 RID: 853
	[UnrealObjectPath("/Script/KuroCrashCollection.KuroCrashCollectionControllerLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCrashCollectionControllerLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600573B RID: 22331 RVA: 0x0007AE10 File Offset: 0x00079010
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrashCollectionControllerLibrary._ClassPtr;
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x0007AE1C File Offset: 0x0007901C
		public UKuroCrashCollectionControllerLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCrashCollectionControllerLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x0007AE44 File Offset: 0x00079044
		[NullableContext(1)]
		public UKuroCrashCollectionControllerLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrashCollectionControllerLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x0007AE77 File Offset: 0x00079077
		[NullableContext(2)]
		public static void UpdateMainCharacter(ACharacter Character)
		{
			UKuroCrashCollectionControllerLibrary.__UpdateMainCharacter_Internal((Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x0007AE8E File Offset: 0x0007908E
		[NullableContext(2)]
		public static void Initialize(UWorld World, FName InActorLocationName, FName InActorRotationName, FName InCameraLocationName, FName InCameraRotationName, FName InWorldName)
		{
			UKuroCrashCollectionControllerLibrary.__Initialize_Internal((World != null) ? World.NativePtr : IntPtr.Zero, InActorLocationName, InActorRotationName, InCameraLocationName, InCameraRotationName, InWorldName);
		}

		// Token: 0x06005740 RID: 22336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMainCharacter_Internal(IntPtr Character);

		// Token: 0x06005741 RID: 22337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr World, FName InActorLocationName, FName InActorRotationName, FName InCameraLocationName, FName InCameraRotationName, FName InWorldName);

		// Token: 0x06005742 RID: 22338 RVA: 0x0007AEAC File Offset: 0x000790AC
		static UKuroCrashCollectionControllerLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrashCollection.KuroCrashCollectionControllerLibrary");
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x0007AEBA File Offset: 0x000790BA
		protected UKuroCrashCollectionControllerLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040023E8 RID: 9192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrashCollection.KuroCrashCollectionControllerLibrary";

		// Token: 0x040023E9 RID: 9193
		private static IntPtr _ClassPtr;

		// Token: 0x040023EA RID: 9194
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
