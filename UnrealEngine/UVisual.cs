using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F4 RID: 10740
	[UnrealObjectPath("/Script/UMG.Visual")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UVisual : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D4A RID: 163146 RVA: 0x003CB01B File Offset: 0x003C921B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVisual._ClassPtr;
		}

		// Token: 0x06027D4B RID: 163147 RVA: 0x003CB028 File Offset: 0x003C9228
		public UVisual() : this(BuiltinUtils.AllocNativeUObject(UVisual.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D4C RID: 163148 RVA: 0x003CB050 File Offset: 0x003C9250
		[NullableContext(1)]
		public UVisual(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVisual.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027D4D RID: 163149 RVA: 0x003CB083 File Offset: 0x003C9283
		static UVisual()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Visual");
		}

		// Token: 0x06027D4E RID: 163150 RVA: 0x003CB091 File Offset: 0x003C9291
		protected UVisual(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C77 RID: 89207
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Visual";

		// Token: 0x04015C78 RID: 89208
		private static IntPtr _ClassPtr;

		// Token: 0x04015C79 RID: 89209
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
