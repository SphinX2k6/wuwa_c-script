using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017E0 RID: 6112
	[UnrealObjectPath("/Script/KuroCrashCollection.KuroCrashCollectionControllerLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCrashCollectionControllerLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016943 RID: 92483 RVA: 0x0020F43D File Offset: 0x0020D63D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrashCollectionControllerLibrary._ClassPtr;
		}

		// Token: 0x06016944 RID: 92484 RVA: 0x0020F44C File Offset: 0x0020D64C
		public UKuroCrashCollectionControllerLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCrashCollectionControllerLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016945 RID: 92485 RVA: 0x0020F474 File Offset: 0x0020D674
		[NullableContext(1)]
		public UKuroCrashCollectionControllerLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrashCollectionControllerLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016946 RID: 92486 RVA: 0x0020F4A7 File Offset: 0x0020D6A7
		[NullableContext(2)]
		public static void UpdateMainCharacter(ACharacter Character)
		{
			UKuroCrashCollectionControllerLibrary.__UpdateMainCharacter_Internal((Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016947 RID: 92487 RVA: 0x0020F4BE File Offset: 0x0020D6BE
		[NullableContext(2)]
		public static void Initialize(UWorld World, FName InActorLocationName, FName InActorRotationName, FName InCameraLocationName, FName InCameraRotationName, FName InWorldName)
		{
			UKuroCrashCollectionControllerLibrary.__Initialize_Internal((World != null) ? World.NativePtr : IntPtr.Zero, InActorLocationName, InActorRotationName, InCameraLocationName, InCameraRotationName, InWorldName);
		}

		// Token: 0x06016948 RID: 92488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMainCharacter_Internal(IntPtr Character);

		// Token: 0x06016949 RID: 92489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr World, FName InActorLocationName, FName InActorRotationName, FName InCameraLocationName, FName InCameraRotationName, FName InWorldName);

		// Token: 0x0601694A RID: 92490 RVA: 0x0020F4DC File Offset: 0x0020D6DC
		static UKuroCrashCollectionControllerLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrashCollection.KuroCrashCollectionControllerLibrary");
		}

		// Token: 0x0601694B RID: 92491 RVA: 0x0020F4EA File Offset: 0x0020D6EA
		protected UKuroCrashCollectionControllerLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C428 RID: 50216
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrashCollection.KuroCrashCollectionControllerLibrary";

		// Token: 0x0400C429 RID: 50217
		private static IntPtr _ClassPtr;

		// Token: 0x0400C42A RID: 50218
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
