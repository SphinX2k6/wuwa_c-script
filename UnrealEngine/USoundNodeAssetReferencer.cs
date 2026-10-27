using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200113A RID: 4410
	[UnrealObjectPath("/Script/Engine.SoundNodeAssetReferencer")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class USoundNodeAssetReferencer : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601021E RID: 66078 RVA: 0x0017C4C5 File Offset: 0x0017A6C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeAssetReferencer._ClassPtr;
		}

		// Token: 0x0601021F RID: 66079 RVA: 0x0017C4D1 File Offset: 0x0017A6D1
		static USoundNodeAssetReferencer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeAssetReferencer");
		}

		// Token: 0x06010220 RID: 66080 RVA: 0x0017C4E0 File Offset: 0x0017A6E0
		protected USoundNodeAssetReferencer() : this(BuiltinUtils.AllocNativeUObject(USoundNodeAssetReferencer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010221 RID: 66081 RVA: 0x0017C508 File Offset: 0x0017A708
		protected USoundNodeAssetReferencer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AD1 RID: 35537
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeAssetReferencer";

		// Token: 0x04008AD2 RID: 35538
		private static IntPtr _ClassPtr;

		// Token: 0x04008AD3 RID: 35539
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
