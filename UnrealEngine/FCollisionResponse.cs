using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000946 RID: 2374
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CollisionResponse")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCollisionResponse : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600862E RID: 34350 RVA: 0x000BF3AA File Offset: 0x000BD5AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionResponse._ScriptStructPtr != 0) ? FCollisionResponse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionResponse", ref FCollisionResponse._ScriptStructPtr);
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x0600862F RID: 34351 RVA: 0x000BF3D0 File Offset: 0x000BD5D0
		// (set) Token: 0x06008630 RID: 34352 RVA: 0x000BF413 File Offset: 0x000BD613
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

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06008631 RID: 34353 RVA: 0x000BF434 File Offset: 0x000BD634
		// (set) Token: 0x06008632 RID: 34354 RVA: 0x000BF477 File Offset: 0x000BD677
		public TArray<FResponseChannel> ResponseArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FResponseChannel> result;
				if ((result = this._ResponseArray) == null)
				{
					result = (this._ResponseArray = new TArray<FResponseChannel>(base.NativePtr + (IntPtr)FCollisionResponse.__PropertyOffset_ResponseArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ResponseArray.CopyAssign(value);
			}
		}

		// Token: 0x06008633 RID: 34355 RVA: 0x000BF485 File Offset: 0x000BD685
		public FCollisionResponse()
		{
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x000BF48D File Offset: 0x000BD68D
		public FCollisionResponse(FCollisionResponseContainer ResponseToChannels, TArray<FResponseChannel> ResponseArray)
		{
			this.ResponseToChannels = ResponseToChannels;
			this.ResponseArray = ResponseArray;
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x000BF4A3 File Offset: 0x000BD6A3
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionResponse.StaticStruct();
		}

		// Token: 0x06008636 RID: 34358 RVA: 0x000BF4AF File Offset: 0x000BD6AF
		[NullableContext(2)]
		public FCollisionResponse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008637 RID: 34359 RVA: 0x000BF4B9 File Offset: 0x000BD6B9
		public FCollisionResponse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x000BF4C4 File Offset: 0x000BD6C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionResponse(Pointer, false, true);
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x000BF4CE File Offset: 0x000BD6CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionResponse(Pointer, MemoryOwner);
		}

		// Token: 0x04003FD6 RID: 16342
		public const string __ObjectPath = "/Script/Engine.CollisionResponse";

		// Token: 0x04003FD7 RID: 16343
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003FD8 RID: 16344
		internal static int __PropertyOffset_ResponseToChannels;

		// Token: 0x04003FD9 RID: 16345
		[Nullable(2)]
		private FCollisionResponseContainer _ResponseToChannels;

		// Token: 0x04003FDA RID: 16346
		internal static int __PropertyOffset_ResponseArray;

		// Token: 0x04003FDB RID: 16347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FResponseChannel> _ResponseArray;
	}
}
