using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BF RID: 959
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARQRCodeUpdatePayload")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FARQRCodeUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600352D RID: 13613 RVA: 0x00051218 File Offset: 0x0004F418
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARQRCodeUpdatePayload._ScriptStructPtr != 0) ? FARQRCodeUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARQRCodeUpdatePayload", ref FARQRCodeUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x0005123C File Offset: 0x0004F43C
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x0005127F File Offset: 0x0004F47F
		public FARSessionPayload SessionPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARSessionPayload result;
				if ((result = this._SessionPayload) == null)
				{
					result = (this._SessionPayload = new FARSessionPayload(base.NativePtr + (IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_SessionPayload, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSessionPayload.StaticStruct(), base.NativePtr + (IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_SessionPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x000512A0 File Offset: 0x0004F4A0
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x000512B4 File Offset: 0x0004F4B4
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x000512C9 File Offset: 0x0004F4C9
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x000512DD File Offset: 0x0004F4DD
		public unsafe FVector Extents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_Extents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_Extents) = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x000512F2 File Offset: 0x0004F4F2
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x00051306 File Offset: 0x0004F506
		public unsafe string QRCode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_QRCode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FARQRCodeUpdatePayload.__PropertyOffset_QRCode)), value);
			}
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0005131B File Offset: 0x0004F51B
		public FARQRCodeUpdatePayload()
		{
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00051323 File Offset: 0x0004F523
		public FARQRCodeUpdatePayload(FARSessionPayload SessionPayload, FTransform WorldTransform, FVector Extents, string QRCode)
		{
			this.SessionPayload = SessionPayload;
			this.WorldTransform = WorldTransform;
			this.Extents = Extents;
			this.QRCode = QRCode;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00051348 File Offset: 0x0004F548
		protected override IntPtr GetUStructPtr()
		{
			return FARQRCodeUpdatePayload.StaticStruct();
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00051354 File Offset: 0x0004F554
		[NullableContext(2)]
		public FARQRCodeUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0005135E File Offset: 0x0004F55E
		public FARQRCodeUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00051369 File Offset: 0x0004F569
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARQRCodeUpdatePayload(Pointer, false, true);
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00051373 File Offset: 0x0004F573
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARQRCodeUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x0400170E RID: 5902
		public const string __ObjectPath = "/Script/AugmentedReality.ARQRCodeUpdatePayload";

		// Token: 0x0400170F RID: 5903
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001710 RID: 5904
		internal static int __PropertyOffset_SessionPayload;

		// Token: 0x04001711 RID: 5905
		[Nullable(2)]
		private FARSessionPayload _SessionPayload;

		// Token: 0x04001712 RID: 5906
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x04001713 RID: 5907
		internal static int __PropertyOffset_Extents;

		// Token: 0x04001714 RID: 5908
		internal static int __PropertyOffset_QRCode;
	}
}
