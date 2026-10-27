using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001917 RID: 6423
	[UnrealObjectPath("/Script/KuroGameplay.KuroTimerSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTimerSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D5A RID: 97626 RVA: 0x0022E7F9 File Offset: 0x0022C9F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTimerSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x06017D5B RID: 97627 RVA: 0x0022E808 File Offset: 0x0022CA08
		public UKuroTimerSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroTimerSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D5C RID: 97628 RVA: 0x0022E830 File Offset: 0x0022CA30
		[NullableContext(1)]
		public UKuroTimerSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTimerSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017D5D RID: 97629 RVA: 0x0022E863 File Offset: 0x0022CA63
		[NullableContext(2)]
		public static void Initialize(UGameInstance World)
		{
			UKuroTimerSystemFunctionLibrary.__Initialize_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017D5E RID: 97630
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x06017D5F RID: 97631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr World);

		// Token: 0x06017D60 RID: 97632 RVA: 0x0022E87A File Offset: 0x0022CA7A
		static UKuroTimerSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroTimerSystemFunctionLibrary");
		}

		// Token: 0x06017D61 RID: 97633 RVA: 0x0022E888 File Offset: 0x0022CA88
		protected UKuroTimerSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEAF RID: 52911
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroTimerSystemFunctionLibrary";

		// Token: 0x0400CEB0 RID: 52912
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEB1 RID: 52913
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
