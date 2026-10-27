using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001E5 RID: 485
	[UnrealObjectPath("/Script/AkAudio.AkAcousticTextureParams")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAkAcousticTextureParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001C92 RID: 7314 RVA: 0x0002A9E5 File Offset: 0x00028BE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkAcousticTextureParams._ScriptStructPtr != 0) ? FAkAcousticTextureParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkAcousticTextureParams", ref FAkAcousticTextureParams._ScriptStructPtr);
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0002AA09 File Offset: 0x00028C09
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0002AA1D File Offset: 0x00028C1D
		public unsafe FVector4 AbsorptionValues
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkAcousticTextureParams.__PropertyOffset_AbsorptionValues);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkAcousticTextureParams.__PropertyOffset_AbsorptionValues) = value;
			}
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0002AA32 File Offset: 0x00028C32
		public FAkAcousticTextureParams()
		{
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0002AA3A File Offset: 0x00028C3A
		public FAkAcousticTextureParams(FVector4 AbsorptionValues)
		{
			this.AbsorptionValues = AbsorptionValues;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0002AA49 File Offset: 0x00028C49
		protected override IntPtr GetUStructPtr()
		{
			return FAkAcousticTextureParams.StaticStruct();
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0002AA55 File Offset: 0x00028C55
		[NullableContext(2)]
		public FAkAcousticTextureParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0002AA5F File Offset: 0x00028C5F
		public FAkAcousticTextureParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0002AA6A File Offset: 0x00028C6A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkAcousticTextureParams(Pointer, false, true);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0002AA74 File Offset: 0x00028C74
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkAcousticTextureParams(Pointer, MemoryOwner);
		}

		// Token: 0x04000953 RID: 2387
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkAcousticTextureParams";

		// Token: 0x04000954 RID: 2388
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000955 RID: 2389
		internal static int __PropertyOffset_AbsorptionValues;
	}
}
