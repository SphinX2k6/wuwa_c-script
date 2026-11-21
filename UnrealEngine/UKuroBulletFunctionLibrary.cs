using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200032A RID: 810
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBulletFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060054E7 RID: 21735 RVA: 0x00076CD7 File Offset: 0x00074ED7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletFunctionLibrary._ClassPtr;
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00076CE4 File Offset: 0x00074EE4
		public UKuroBulletFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x00076D0C File Offset: 0x00074F0C
		[NullableContext(1)]
		public UKuroBulletFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00076D40 File Offset: 0x00074F40
		[NullableContext(2)]
		public static int SpawnPattern(IBulletContext PatternContext, UKuroBulletPatternDataAsset PatternDA)
		{
			FScriptInterface fscriptInterface = new FScriptInterface(PatternContext, (PatternContext != null) ? PatternContext.InterfaceOffset() : 0);
			return UKuroBulletFunctionLibrary.__SpawnPattern_Internal(fscriptInterface, (PatternDA != null) ? PatternDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054EB RID: 21739
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShowEmitterDebugDraw(bool Value);

		// Token: 0x060054EC RID: 21740
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShowBulletCollision(bool Value);

		// Token: 0x060054ED RID: 21741 RVA: 0x00076D78 File Offset: 0x00074F78
		[NullableContext(2)]
		public static void DestroyPatternsByOwner(AActor Owner)
		{
			UKuroBulletFunctionLibrary.__DestroyPatternsByOwner_Internal((Owner != null) ? Owner.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060054EE RID: 21742
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyPattern(int PatternId);

		// Token: 0x060054EF RID: 21743
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyBulletById(int BulletEntityId, bool ClearOwner = false);

		// Token: 0x060054F0 RID: 21744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnPattern_Internal(in FScriptInterface PatternContext, IntPtr PatternDA);

		// Token: 0x060054F1 RID: 21745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyPatternsByOwner_Internal(IntPtr Owner);

		// Token: 0x060054F2 RID: 21746 RVA: 0x00076D8F File Offset: 0x00074F8F
		static UKuroBulletFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletFunctionLibrary");
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00076D9D File Offset: 0x00074F9D
		protected UKuroBulletFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022B2 RID: 8882
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletFunctionLibrary";

		// Token: 0x040022B3 RID: 8883
		private static IntPtr _ClassPtr;

		// Token: 0x040022B4 RID: 8884
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
