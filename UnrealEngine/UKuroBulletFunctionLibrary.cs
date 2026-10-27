using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016FB RID: 5883
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBulletFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601540D RID: 87053 RVA: 0x001F3DB5 File Offset: 0x001F1FB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletFunctionLibrary._ClassPtr;
		}

		// Token: 0x0601540E RID: 87054 RVA: 0x001F3DC4 File Offset: 0x001F1FC4
		public UKuroBulletFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601540F RID: 87055 RVA: 0x001F3DEC File Offset: 0x001F1FEC
		[NullableContext(1)]
		public UKuroBulletFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015410 RID: 87056 RVA: 0x001F3E20 File Offset: 0x001F2020
		[NullableContext(2)]
		public static int SpawnPattern(IBulletContext PatternContext, UKuroBulletPatternDataAsset PatternDA)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(PatternContext, (PatternContext != null) ? PatternContext.InterfaceOffset() : 0);
			return UKuroBulletFunctionLibrary.__SpawnPattern_Internal(fscriptInterface, (PatternDA != null) ? PatternDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015411 RID: 87057
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShowEmitterDebugDraw(bool Value);

		// Token: 0x06015412 RID: 87058
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShowBulletCollision(bool Value);

		// Token: 0x06015413 RID: 87059 RVA: 0x001F3E58 File Offset: 0x001F2058
		[NullableContext(2)]
		public static void DestroyPatternsByOwner(AActor Owner)
		{
			UKuroBulletFunctionLibrary.__DestroyPatternsByOwner_Internal((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015414 RID: 87060
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyPattern(int PatternId);

		// Token: 0x06015415 RID: 87061
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyBulletById(int BulletEntityId, bool ClearOwner = false);

		// Token: 0x06015416 RID: 87062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnPattern_Internal(in FScriptInterface PatternContext, IntPtr PatternDA);

		// Token: 0x06015417 RID: 87063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPatternsByOwner_Internal(IntPtr Owner);

		// Token: 0x06015418 RID: 87064 RVA: 0x001F3E6F File Offset: 0x001F206F
		static UKuroBulletFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletFunctionLibrary");
		}

		// Token: 0x06015419 RID: 87065 RVA: 0x001F3E7D File Offset: 0x001F207D
		protected UKuroBulletFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B96D RID: 47469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletFunctionLibrary";

		// Token: 0x0400B96E RID: 47470
		private static IntPtr _ClassPtr;

		// Token: 0x0400B96F RID: 47471
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
