using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB4 RID: 7860
	[UnrealObjectPath("/Script/KuroUtility.KuroCycleCounterLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCycleCounterLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD4B RID: 122187 RVA: 0x002C223A File Offset: 0x002C043A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCycleCounterLibrary._ClassPtr;
		}

		// Token: 0x0601DD4C RID: 122188 RVA: 0x002C2248 File Offset: 0x002C0448
		public UKuroCycleCounterLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCycleCounterLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD4D RID: 122189 RVA: 0x002C2270 File Offset: 0x002C0470
		[NullableContext(1)]
		public UKuroCycleCounterLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCycleCounterLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD4E RID: 122190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopCycleCounter();

		// Token: 0x0601DD4F RID: 122191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartCycleCounterByName(in FName StatName);

		// Token: 0x0601DD50 RID: 122192
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartCycleCounter(int StatIndex);

		// Token: 0x0601DD51 RID: 122193
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeEnvironment();

		// Token: 0x0601DD52 RID: 122194
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x0601DD53 RID: 122195
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CreateCycleCounter(in FName StatName);

		// Token: 0x0601DD54 RID: 122196 RVA: 0x002C22A3 File Offset: 0x002C04A3
		static UKuroCycleCounterLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroCycleCounterLibrary");
		}

		// Token: 0x0601DD55 RID: 122197 RVA: 0x002C22B1 File Offset: 0x002C04B1
		protected UKuroCycleCounterLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102AC RID: 66220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroCycleCounterLibrary";

		// Token: 0x040102AD RID: 66221
		private static IntPtr _ClassPtr;

		// Token: 0x040102AE RID: 66222
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
