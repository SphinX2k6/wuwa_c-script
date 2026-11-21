using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A8 RID: 424
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CollisionResponse")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCollisionResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F89 RID: 8073 RVA: 0x0002D9C7 File Offset: 0x0002BBC7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionResponse._ScriptStructPtr != 0) ? FCollisionResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionResponse", ref FCollisionResponse._ScriptStructPtr);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x0002D9EC File Offset: 0x0002BBEC
		// (set) Token: 0x06001F8B RID: 8075 RVA: 0x0002DA2F File Offset: 0x0002BC2F
		public FCollisionResponseContainer ResponseToChannels
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionResponseContainer result;
				if ((result = this._ResponseToChannels) == null)
				{
					result = (this._ResponseToChannels = new FCollisionResponseContainer(base.NativePtr + (IntPtr)FCollisionResponse.__PropertyOffset_ResponseToChannels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionResponseContainer.StaticStruct(), base.NativePtr + (IntPtr)FCollisionResponse.__PropertyOffset_ResponseToChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0002DA50 File Offset: 0x0002BC50
		public FCollisionResponse()
		{
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0002DA58 File Offset: 0x0002BC58
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionResponse.StaticStruct();
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0002DA64 File Offset: 0x0002BC64
		[NullableContext(2)]
		public FCollisionResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0002DA6E File Offset: 0x0002BC6E
		public FCollisionResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0002DA79 File Offset: 0x0002BC79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionResponse(Pointer, false, true);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0002DA83 File Offset: 0x0002BC83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionResponse(Pointer, MemoryOwner);
		}

		// Token: 0x04000A71 RID: 2673
		public const string __ObjectPath = "/Script/Engine.CollisionResponse";

		// Token: 0x04000A72 RID: 2674
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A73 RID: 2675
		internal static int __PropertyOffset_ResponseToChannels;

		// Token: 0x04000A74 RID: 2676
		[Nullable(2)]
		private FCollisionResponseContainer _ResponseToChannels;
	}
}
