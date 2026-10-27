using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000989 RID: 2441
	[UnrealObjectPath("/Script/Engine.CustomChannelSetup")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCustomChannelSetup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060089F4 RID: 35316 RVA: 0x000C59CB File Offset: 0x000C3BCB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomChannelSetup._ScriptStructPtr != 0) ? FCustomChannelSetup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomChannelSetup", ref FCustomChannelSetup._ScriptStructPtr);
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x060089F5 RID: 35317 RVA: 0x000C59EF File Offset: 0x000C3BEF
		// (set) Token: 0x060089F6 RID: 35318 RVA: 0x000C5A03 File Offset: 0x000C3C03
		public unsafe TEnumAsByte<ECollisionChannel> Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x060089F7 RID: 35319 RVA: 0x000C5A18 File Offset: 0x000C3C18
		// (set) Token: 0x060089F8 RID: 35320 RVA: 0x000C5A2C File Offset: 0x000C3C2C
		public unsafe TEnumAsByte<ECollisionResponse> DefaultResponse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_DefaultResponse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_DefaultResponse) = value;
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x060089F9 RID: 35321 RVA: 0x000C5A41 File Offset: 0x000C3C41
		// (set) Token: 0x060089FA RID: 35322 RVA: 0x000C5A51 File Offset: 0x000C3C51
		public unsafe bool bTraceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_bTraceType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_bTraceType) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x060089FB RID: 35323 RVA: 0x000C5A62 File Offset: 0x000C3C62
		// (set) Token: 0x060089FC RID: 35324 RVA: 0x000C5A72 File Offset: 0x000C3C72
		public unsafe bool bStaticObject
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_bStaticObject) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_bStaticObject) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x060089FD RID: 35325 RVA: 0x000C5A83 File Offset: 0x000C3C83
		// (set) Token: 0x060089FE RID: 35326 RVA: 0x000C5A97 File Offset: 0x000C3C97
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomChannelSetup.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x000C5AAC File Offset: 0x000C3CAC
		public FCustomChannelSetup()
		{
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x000C5AB4 File Offset: 0x000C3CB4
		public FCustomChannelSetup(TEnumAsByte<ECollisionChannel> Channel, TEnumAsByte<ECollisionResponse> DefaultResponse, bool bTraceType, bool bStaticObject, FName Name)
		{
			this.Channel = Channel;
			this.DefaultResponse = DefaultResponse;
			this.bTraceType = bTraceType;
			this.bStaticObject = bStaticObject;
			this.Name = Name;
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x000C5AE1 File Offset: 0x000C3CE1
		protected override IntPtr GetUStructPtr()
		{
			return FCustomChannelSetup.StaticStruct();
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x000C5AED File Offset: 0x000C3CED
		[NullableContext(2)]
		public FCustomChannelSetup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x000C5AF7 File Offset: 0x000C3CF7
		public FCustomChannelSetup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x000C5B02 File Offset: 0x000C3D02
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomChannelSetup(Pointer, false, true);
		}

		// Token: 0x06008A05 RID: 35333 RVA: 0x000C5B0C File Offset: 0x000C3D0C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomChannelSetup(Pointer, MemoryOwner);
		}

		// Token: 0x0400417F RID: 16767
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CustomChannelSetup";

		// Token: 0x04004180 RID: 16768
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004181 RID: 16769
		internal static int __PropertyOffset_Channel;

		// Token: 0x04004182 RID: 16770
		internal static int __PropertyOffset_DefaultResponse;

		// Token: 0x04004183 RID: 16771
		internal static int __PropertyOffset_bTraceType;

		// Token: 0x04004184 RID: 16772
		internal static int __PropertyOffset_bStaticObject;

		// Token: 0x04004185 RID: 16773
		internal static int __PropertyOffset_Name;
	}
}
