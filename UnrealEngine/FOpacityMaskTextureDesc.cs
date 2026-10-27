using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200261E RID: 9758
	[UnrealObjectPath("/Script/OpacityMicroMap.OpacityMaskTextureDesc")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FOpacityMaskTextureDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602447D RID: 148605 RVA: 0x0035B73F File Offset: 0x0035993F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpacityMaskTextureDesc._ScriptStructPtr != 0) ? FOpacityMaskTextureDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OpacityMicroMap.OpacityMaskTextureDesc", ref FOpacityMaskTextureDesc._ScriptStructPtr);
		}

		// Token: 0x17008BB1 RID: 35761
		// (get) Token: 0x0602447E RID: 148606 RVA: 0x0035B763 File Offset: 0x00359963
		// (set) Token: 0x0602447F RID: 148607 RVA: 0x0035B777 File Offset: 0x00359977
		public unsafe FName TextureParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMaskTextureDesc.__PropertyOffset_TextureParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMaskTextureDesc.__PropertyOffset_TextureParameterName) = value;
			}
		}

		// Token: 0x17008BB2 RID: 35762
		// (get) Token: 0x06024480 RID: 148608 RVA: 0x0035B78C File Offset: 0x0035998C
		// (set) Token: 0x06024481 RID: 148609 RVA: 0x0035B79C File Offset: 0x0035999C
		public unsafe int AlphaChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpacityMaskTextureDesc.__PropertyOffset_AlphaChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpacityMaskTextureDesc.__PropertyOffset_AlphaChannel) = value;
			}
		}

		// Token: 0x06024482 RID: 148610 RVA: 0x0035B7AD File Offset: 0x003599AD
		public FOpacityMaskTextureDesc()
		{
		}

		// Token: 0x06024483 RID: 148611 RVA: 0x0035B7B5 File Offset: 0x003599B5
		public FOpacityMaskTextureDesc(FName TextureParameterName, int AlphaChannel)
		{
			this.TextureParameterName = TextureParameterName;
			this.AlphaChannel = AlphaChannel;
		}

		// Token: 0x06024484 RID: 148612 RVA: 0x0035B7CB File Offset: 0x003599CB
		protected override IntPtr GetUStructPtr()
		{
			return FOpacityMaskTextureDesc.StaticStruct();
		}

		// Token: 0x06024485 RID: 148613 RVA: 0x0035B7D7 File Offset: 0x003599D7
		[NullableContext(2)]
		public FOpacityMaskTextureDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024486 RID: 148614 RVA: 0x0035B7E1 File Offset: 0x003599E1
		public FOpacityMaskTextureDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024487 RID: 148615 RVA: 0x0035B7EC File Offset: 0x003599EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpacityMaskTextureDesc(Pointer, false, true);
		}

		// Token: 0x06024488 RID: 148616 RVA: 0x0035B7F6 File Offset: 0x003599F6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpacityMaskTextureDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04013765 RID: 79717
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OpacityMicroMap.OpacityMaskTextureDesc";

		// Token: 0x04013766 RID: 79718
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013767 RID: 79719
		internal static int __PropertyOffset_TextureParameterName;

		// Token: 0x04013768 RID: 79720
		internal static int __PropertyOffset_AlphaChannel;
	}
}
