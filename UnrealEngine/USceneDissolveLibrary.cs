using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001935 RID: 6453
	[UnrealObjectPath("/Script/KuroGameplay.SceneDissolveLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USceneDissolveLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017ED0 RID: 98000 RVA: 0x00230FD2 File Offset: 0x0022F1D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneDissolveLibrary._ClassPtr;
		}

		// Token: 0x06017ED1 RID: 98001 RVA: 0x00230FE0 File Offset: 0x0022F1E0
		public USceneDissolveLibrary() : this(BuiltinUtils.AllocNativeUObject(USceneDissolveLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017ED2 RID: 98002 RVA: 0x00231008 File Offset: 0x0022F208
		[NullableContext(1)]
		public USceneDissolveLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneDissolveLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017ED3 RID: 98003 RVA: 0x0023103B File Offset: 0x0022F23B
		[NullableContext(2)]
		public static void TagActorAsDissolveSide(AActor Actor, int Side, bool bPersistent = false)
		{
			USceneDissolveLibrary.__TagActorAsDissolveSide_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Side, bPersistent);
		}

		// Token: 0x06017ED4 RID: 98004
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSphere(FVector SphereCenter, float SphereRadius);

		// Token: 0x06017ED5 RID: 98005
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEdgeWidth(float EdgeWidth);

		// Token: 0x06017ED6 RID: 98006
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDissolveSphere(FVector SphereCenter, float SphereRadius, float EdgeWidth = 50f);

		// Token: 0x06017ED7 RID: 98007
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetCustomPrimitiveDataIndex();

		// Token: 0x06017ED8 RID: 98008
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearDissolve();

		// Token: 0x06017ED9 RID: 98009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TagActorAsDissolveSide_Internal(IntPtr Actor, int Side, bool bPersistent);

		// Token: 0x06017EDA RID: 98010 RVA: 0x00231054 File Offset: 0x0022F254
		static USceneDissolveLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.SceneDissolveLibrary");
		}

		// Token: 0x06017EDB RID: 98011 RVA: 0x00231062 File Offset: 0x0022F262
		protected USceneDissolveLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CF40 RID: 53056
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.SceneDissolveLibrary";

		// Token: 0x0400CF41 RID: 53057
		private static IntPtr _ClassPtr;

		// Token: 0x0400CF42 RID: 53058
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
