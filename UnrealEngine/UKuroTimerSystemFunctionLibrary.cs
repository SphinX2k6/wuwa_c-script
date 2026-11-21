using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000406 RID: 1030
	[UnrealObjectPath("/Script/KuroGameplay.KuroTimerSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTimerSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060064DC RID: 25820 RVA: 0x0008FF39 File Offset: 0x0008E139
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTimerSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x0008FF48 File Offset: 0x0008E148
		public UKuroTimerSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroTimerSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x0008FF70 File Offset: 0x0008E170
		[NullableContext(1)]
		public UKuroTimerSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTimerSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x0008FFA3 File Offset: 0x0008E1A3
		[NullableContext(2)]
		public static void Initialize(UGameInstance World)
		{
			UKuroTimerSystemFunctionLibrary.__Initialize_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060064E0 RID: 25824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x060064E1 RID: 25825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr World);

		// Token: 0x060064E2 RID: 25826 RVA: 0x0008FFBA File Offset: 0x0008E1BA
		static UKuroTimerSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroTimerSystemFunctionLibrary");
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x0008FFC8 File Offset: 0x0008E1C8
		protected UKuroTimerSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A7D RID: 10877
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroTimerSystemFunctionLibrary";

		// Token: 0x04002A7E RID: 10878
		private static IntPtr _ClassPtr;

		// Token: 0x04002A7F RID: 10879
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
