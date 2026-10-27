using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002200 RID: 8704
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkEyeSecondLightUniformData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkEyeSecondLightUniformData : FLiveLinkBaseUniformData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212B1 RID: 135857 RVA: 0x0030E7B9 File Offset: 0x0030C9B9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkEyeSecondLightUniformData._ScriptStructPtr != 0) ? FLiveLinkEyeSecondLightUniformData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkEyeSecondLightUniformData", ref FLiveLinkEyeSecondLightUniformData._ScriptStructPtr);
		}

		// Token: 0x1700817C RID: 33148
		// (get) Token: 0x060212B2 RID: 135858 RVA: 0x0030E7DD File Offset: 0x0030C9DD
		// (set) Token: 0x060212B3 RID: 135859 RVA: 0x0030E7ED File Offset: 0x0030C9ED
		public unsafe float PositionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkEyeSecondLightUniformData.__PropertyOffset_PositionX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkEyeSecondLightUniformData.__PropertyOffset_PositionX) = value;
			}
		}

		// Token: 0x1700817D RID: 33149
		// (get) Token: 0x060212B4 RID: 135860 RVA: 0x0030E7FE File Offset: 0x0030C9FE
		// (set) Token: 0x060212B5 RID: 135861 RVA: 0x0030E80E File Offset: 0x0030CA0E
		public unsafe float PositionY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkEyeSecondLightUniformData.__PropertyOffset_PositionY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkEyeSecondLightUniformData.__PropertyOffset_PositionY) = value;
			}
		}

		// Token: 0x060212B6 RID: 135862 RVA: 0x0030E81F File Offset: 0x0030CA1F
		public FLiveLinkEyeSecondLightUniformData()
		{
		}

		// Token: 0x060212B7 RID: 135863 RVA: 0x0030E827 File Offset: 0x0030CA27
		public FLiveLinkEyeSecondLightUniformData(float PositionX, float PositionY)
		{
			this.PositionX = PositionX;
			this.PositionY = PositionY;
		}

		// Token: 0x060212B8 RID: 135864 RVA: 0x0030E83D File Offset: 0x0030CA3D
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkEyeSecondLightUniformData.StaticStruct();
		}

		// Token: 0x060212B9 RID: 135865 RVA: 0x0030E849 File Offset: 0x0030CA49
		[NullableContext(2)]
		public FLiveLinkEyeSecondLightUniformData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212BA RID: 135866 RVA: 0x0030E853 File Offset: 0x0030CA53
		public FLiveLinkEyeSecondLightUniformData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212BB RID: 135867 RVA: 0x0030E85E File Offset: 0x0030CA5E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkEyeSecondLightUniformData(Pointer, false, true);
		}

		// Token: 0x060212BC RID: 135868 RVA: 0x0030E868 File Offset: 0x0030CA68
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkEyeSecondLightUniformData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B26 RID: 72486
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkEyeSecondLightUniformData";

		// Token: 0x04011B27 RID: 72487
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B28 RID: 72488
		internal static int __PropertyOffset_PositionX;

		// Token: 0x04011B29 RID: 72489
		internal static int __PropertyOffset_PositionY;
	}
}
