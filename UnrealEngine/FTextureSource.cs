using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011E3 RID: 4579
	[UnrealObjectPath("/Script/Engine.TextureSource")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FTextureSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010DE1 RID: 69089 RVA: 0x0018C61D File Offset: 0x0018A81D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureSource._ScriptStructPtr != 0) ? FTextureSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextureSource", ref FTextureSource._ScriptStructPtr);
		}

		// Token: 0x06010DE2 RID: 69090 RVA: 0x0018C641 File Offset: 0x0018A841
		public FTextureSource()
		{
		}

		// Token: 0x06010DE3 RID: 69091 RVA: 0x0018C649 File Offset: 0x0018A849
		public FTextureSource(FGuid Id, int BaseBlockX, int BaseBlockY, int SizeX, int SizeY, int NumSlices, int NumMips, int NumLayers, bool bPNGCompressed, bool bGuidIsHash, TEnumAsByte<ETextureSourceFormat> Format, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<ETextureSourceFormat>> LayerFormat, [Nullable(1)] TArray<FTextureSourceBlock> Blocks)
		{
		}

		// Token: 0x06010DE4 RID: 69092 RVA: 0x0018C651 File Offset: 0x0018A851
		protected override IntPtr GetUStructPtr()
		{
			return FTextureSource.StaticStruct();
		}

		// Token: 0x06010DE5 RID: 69093 RVA: 0x0018C65D File Offset: 0x0018A85D
		[NullableContext(2)]
		public FTextureSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010DE6 RID: 69094 RVA: 0x0018C667 File Offset: 0x0018A867
		public FTextureSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010DE7 RID: 69095 RVA: 0x0018C672 File Offset: 0x0018A872
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureSource(Pointer, false, true);
		}

		// Token: 0x06010DE8 RID: 69096 RVA: 0x0018C67C File Offset: 0x0018A87C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureSource(Pointer, MemoryOwner);
		}

		// Token: 0x040090AE RID: 37038
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TextureSource";

		// Token: 0x040090AF RID: 37039
		private static IntPtr _ScriptStructPtr;
	}
}
