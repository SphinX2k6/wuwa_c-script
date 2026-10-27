using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200179B RID: 6043
	[UnrealObjectPath("/Script/KuroComputeShader.KuroClothParticleData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroClothParticleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015C81 RID: 89217 RVA: 0x001FFF3C File Offset: 0x001FE13C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroClothParticleData._ScriptStructPtr != 0) ? FKuroClothParticleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroClothParticleData", ref FKuroClothParticleData._ScriptStructPtr);
		}

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x06015C82 RID: 89218 RVA: 0x001FFF60 File Offset: 0x001FE160
		// (set) Token: 0x06015C83 RID: 89219 RVA: 0x001FFF74 File Offset: 0x001FE174
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothParticleData.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothParticleData.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x06015C84 RID: 89220 RVA: 0x001FFF89 File Offset: 0x001FE189
		// (set) Token: 0x06015C85 RID: 89221 RVA: 0x001FFF99 File Offset: 0x001FE199
		public unsafe bool bPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothParticleData.__PropertyOffset_bPinned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothParticleData.__PropertyOffset_bPinned) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005647 RID: 22087
		// (get) Token: 0x06015C86 RID: 89222 RVA: 0x001FFFAA File Offset: 0x001FE1AA
		// (set) Token: 0x06015C87 RID: 89223 RVA: 0x001FFFBA File Offset: 0x001FE1BA
		public unsafe bool bDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroClothParticleData.__PropertyOffset_bDead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroClothParticleData.__PropertyOffset_bDead) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015C88 RID: 89224 RVA: 0x001FFFCB File Offset: 0x001FE1CB
		public FKuroClothParticleData()
		{
		}

		// Token: 0x06015C89 RID: 89225 RVA: 0x001FFFD3 File Offset: 0x001FE1D3
		public FKuroClothParticleData(FVector Position, bool bPinned, bool bDead)
		{
			this.Position = Position;
			this.bPinned = bPinned;
			this.bDead = bDead;
		}

		// Token: 0x06015C8A RID: 89226 RVA: 0x001FFFF0 File Offset: 0x001FE1F0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroClothParticleData.StaticStruct();
		}

		// Token: 0x06015C8B RID: 89227 RVA: 0x001FFFFC File Offset: 0x001FE1FC
		[NullableContext(2)]
		public FKuroClothParticleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015C8C RID: 89228 RVA: 0x00200006 File Offset: 0x001FE206
		public FKuroClothParticleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015C8D RID: 89229 RVA: 0x00200011 File Offset: 0x001FE211
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroClothParticleData(Pointer, false, true);
		}

		// Token: 0x06015C8E RID: 89230 RVA: 0x0020001B File Offset: 0x001FE21B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroClothParticleData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BE2C RID: 48684
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroClothParticleData";

		// Token: 0x0400BE2D RID: 48685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BE2E RID: 48686
		internal static int __PropertyOffset_Position;

		// Token: 0x0400BE2F RID: 48687
		internal static int __PropertyOffset_bPinned;

		// Token: 0x0400BE30 RID: 48688
		internal static int __PropertyOffset_bDead;
	}
}
