using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200123C RID: 4668
	[UnrealObjectPath("/Script/Engine.VOIPStatics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UVOIPStatics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601126F RID: 70255 RVA: 0x00192E0A File Offset: 0x0019100A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVOIPStatics._ClassPtr;
		}

		// Token: 0x06011270 RID: 70256 RVA: 0x00192E18 File Offset: 0x00191018
		public UVOIPStatics() : this(BuiltinUtils.AllocNativeUObject(UVOIPStatics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011271 RID: 70257 RVA: 0x00192E40 File Offset: 0x00191040
		[NullableContext(1)]
		public UVOIPStatics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVOIPStatics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011272 RID: 70258
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetMicThreshold(float InThreshold);

		// Token: 0x06011273 RID: 70259 RVA: 0x00192E73 File Offset: 0x00191073
		static UVOIPStatics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VOIPStatics");
		}

		// Token: 0x06011274 RID: 70260 RVA: 0x00192E81 File Offset: 0x00191081
		protected UVOIPStatics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092DD RID: 37597
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VOIPStatics";

		// Token: 0x040092DE RID: 37598
		private static IntPtr _ClassPtr;

		// Token: 0x040092DF RID: 37599
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
