using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009E0 RID: 2528
	[UnrealObjectPath("/Script/Engine.DynamicTextureInstance")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FDynamicTextureInstance : FStreamableTextureInstance, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008EB1 RID: 36529 RVA: 0x000CC06D File Offset: 0x000CA26D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDynamicTextureInstance._ScriptStructPtr != 0) ? FDynamicTextureInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DynamicTextureInstance", ref FDynamicTextureInstance._ScriptStructPtr);
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06008EB2 RID: 36530 RVA: 0x000CC091 File Offset: 0x000CA291
		// (set) Token: 0x06008EB3 RID: 36531 RVA: 0x000CC0A5 File Offset: 0x000CA2A5
		[Nullable(2)]
		public unsafe UTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FDynamicTextureInstance.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDynamicTextureInstance.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06008EB4 RID: 36532 RVA: 0x000CC0BA File Offset: 0x000CA2BA
		// (set) Token: 0x06008EB5 RID: 36533 RVA: 0x000CC0CA File Offset: 0x000CA2CA
		public unsafe bool bAttached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureInstance.__PropertyOffset_bAttached) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureInstance.__PropertyOffset_bAttached) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06008EB6 RID: 36534 RVA: 0x000CC0DB File Offset: 0x000CA2DB
		// (set) Token: 0x06008EB7 RID: 36535 RVA: 0x000CC0EB File Offset: 0x000CA2EB
		public unsafe float OriginalRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDynamicTextureInstance.__PropertyOffset_OriginalRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDynamicTextureInstance.__PropertyOffset_OriginalRadius) = value;
			}
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x000CC0FC File Offset: 0x000CA2FC
		public FDynamicTextureInstance()
		{
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x000CC104 File Offset: 0x000CA304
		[NullableContext(1)]
		public FDynamicTextureInstance(UTexture2D Texture, bool bAttached, float OriginalRadius)
		{
			this.Texture = Texture;
			this.bAttached = bAttached;
			this.OriginalRadius = OriginalRadius;
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x000CC121 File Offset: 0x000CA321
		protected override IntPtr GetUStructPtr()
		{
			return FDynamicTextureInstance.StaticStruct();
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x000CC12D File Offset: 0x000CA32D
		[NullableContext(2)]
		public FDynamicTextureInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x000CC137 File Offset: 0x000CA337
		public FDynamicTextureInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x000CC142 File Offset: 0x000CA342
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDynamicTextureInstance(Pointer, false, true);
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x000CC14C File Offset: 0x000CA34C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDynamicTextureInstance(Pointer, MemoryOwner);
		}

		// Token: 0x040043E0 RID: 17376
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DynamicTextureInstance";

		// Token: 0x040043E1 RID: 17377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040043E2 RID: 17378
		internal static int __PropertyOffset_Texture;

		// Token: 0x040043E3 RID: 17379
		internal static int __PropertyOffset_bAttached;

		// Token: 0x040043E4 RID: 17380
		internal static int __PropertyOffset_OriginalRadius;
	}
}
