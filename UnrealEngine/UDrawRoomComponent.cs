using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200026A RID: 618
	[UnrealObjectPath("/Script/AkAudio.DrawRoomComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class UDrawRoomComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002406 RID: 9222 RVA: 0x00035716 File Offset: 0x00033916
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDrawRoomComponent._ClassPtr;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00035724 File Offset: 0x00033924
		public UDrawRoomComponent() : this(BuiltinUtils.AllocNativeUObject(UDrawRoomComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0003574C File Offset: 0x0003394C
		[NullableContext(1)]
		public UDrawRoomComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDrawRoomComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0003577F File Offset: 0x0003397F
		static UDrawRoomComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.DrawRoomComponent");
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0003578D File Offset: 0x0003398D
		protected UDrawRoomComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C8B RID: 3211
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.DrawRoomComponent";

		// Token: 0x04000C8C RID: 3212
		private static IntPtr _ClassPtr;

		// Token: 0x04000C8D RID: 3213
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
