using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E3 RID: 4835
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.ClientTypeInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FClientTypeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011B8E RID: 72590 RVA: 0x001A0444 File Offset: 0x0019E644
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClientTypeInfo._ScriptStructPtr != 0) ? FClientTypeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.ClientTypeInfo", ref FClientTypeInfo._ScriptStructPtr);
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x06011B8F RID: 72591 RVA: 0x001A0468 File Offset: 0x0019E668
		// (set) Token: 0x06011B90 RID: 72592 RVA: 0x001A0478 File Offset: 0x0019E678
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClientTypeInfo.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClientTypeInfo.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x06011B91 RID: 72593 RVA: 0x001A0489 File Offset: 0x0019E689
		// (set) Token: 0x06011B92 RID: 72594 RVA: 0x001A049D File Offset: 0x0019E69D
		public unsafe string DeviceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FClientTypeInfo.__PropertyOffset_DeviceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FClientTypeInfo.__PropertyOffset_DeviceId)), value);
			}
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x06011B93 RID: 72595 RVA: 0x001A04B2 File Offset: 0x0019E6B2
		// (set) Token: 0x06011B94 RID: 72596 RVA: 0x001A04C6 File Offset: 0x0019E6C6
		public unsafe string UserId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FClientTypeInfo.__PropertyOffset_UserId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FClientTypeInfo.__PropertyOffset_UserId)), value);
			}
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x06011B95 RID: 72597 RVA: 0x001A04DB File Offset: 0x0019E6DB
		// (set) Token: 0x06011B96 RID: 72598 RVA: 0x001A04EB File Offset: 0x0019E6EB
		public unsafe int Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClientTypeInfo.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClientTypeInfo.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x06011B97 RID: 72599 RVA: 0x001A04FC File Offset: 0x0019E6FC
		// (set) Token: 0x06011B98 RID: 72600 RVA: 0x001A050C File Offset: 0x0019E70C
		public unsafe int Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClientTypeInfo.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClientTypeInfo.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06011B99 RID: 72601 RVA: 0x001A051D File Offset: 0x0019E71D
		public FClientTypeInfo()
		{
		}

		// Token: 0x06011B9A RID: 72602 RVA: 0x001A0525 File Offset: 0x0019E725
		public FClientTypeInfo(int Type, string DeviceId, string UserId, int Width, int Height)
		{
			this.Type = Type;
			this.DeviceId = DeviceId;
			this.UserId = UserId;
			this.Width = Width;
			this.Height = Height;
		}

		// Token: 0x06011B9B RID: 72603 RVA: 0x001A0552 File Offset: 0x0019E752
		protected override IntPtr GetUStructPtr()
		{
			return FClientTypeInfo.StaticStruct();
		}

		// Token: 0x06011B9C RID: 72604 RVA: 0x001A055E File Offset: 0x0019E75E
		[NullableContext(2)]
		public FClientTypeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011B9D RID: 72605 RVA: 0x001A0568 File Offset: 0x0019E768
		public FClientTypeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011B9E RID: 72606 RVA: 0x001A0573 File Offset: 0x0019E773
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClientTypeInfo(Pointer, false, true);
		}

		// Token: 0x06011B9F RID: 72607 RVA: 0x001A057D File Offset: 0x0019E77D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClientTypeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009830 RID: 38960
		public const string __ObjectPath = "/Script/GameMatrix.ClientTypeInfo";

		// Token: 0x04009831 RID: 38961
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009832 RID: 38962
		internal static int __PropertyOffset_Type;

		// Token: 0x04009833 RID: 38963
		internal static int __PropertyOffset_DeviceId;

		// Token: 0x04009834 RID: 38964
		internal static int __PropertyOffset_UserId;

		// Token: 0x04009835 RID: 38965
		internal static int __PropertyOffset_Width;

		// Token: 0x04009836 RID: 38966
		internal static int __PropertyOffset_Height;
	}
}
