using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F69 RID: 8041
	[UnrealObjectPath("/Script/Landscape.HeightmapData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FHeightmapData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E7F1 RID: 124913 RVA: 0x002D5494 File Offset: 0x002D3694
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHeightmapData._ScriptStructPtr != 0) ? FHeightmapData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.HeightmapData", ref FHeightmapData._ScriptStructPtr);
		}

		// Token: 0x17007945 RID: 31045
		// (get) Token: 0x0601E7F2 RID: 124914 RVA: 0x002D54B8 File Offset: 0x002D36B8
		// (set) Token: 0x0601E7F3 RID: 124915 RVA: 0x002D54CC File Offset: 0x002D36CC
		[Nullable(2)]
		public unsafe UTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FHeightmapData.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHeightmapData.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x0601E7F4 RID: 124916 RVA: 0x002D54E1 File Offset: 0x002D36E1
		public FHeightmapData()
		{
		}

		// Token: 0x0601E7F5 RID: 124917 RVA: 0x002D54E9 File Offset: 0x002D36E9
		[NullableContext(1)]
		public FHeightmapData(UTexture2D Texture)
		{
			this.Texture = Texture;
		}

		// Token: 0x0601E7F6 RID: 124918 RVA: 0x002D54F8 File Offset: 0x002D36F8
		protected override IntPtr GetUStructPtr()
		{
			return FHeightmapData.StaticStruct();
		}

		// Token: 0x0601E7F7 RID: 124919 RVA: 0x002D5504 File Offset: 0x002D3704
		[NullableContext(2)]
		public FHeightmapData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E7F8 RID: 124920 RVA: 0x002D550E File Offset: 0x002D370E
		public FHeightmapData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E7F9 RID: 124921 RVA: 0x002D5519 File Offset: 0x002D3719
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHeightmapData(Pointer, false, true);
		}

		// Token: 0x0601E7FA RID: 124922 RVA: 0x002D5523 File Offset: 0x002D3723
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHeightmapData(Pointer, MemoryOwner);
		}

		// Token: 0x040107B3 RID: 67507
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.HeightmapData";

		// Token: 0x040107B4 RID: 67508
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107B5 RID: 67509
		internal static int __PropertyOffset_Texture;
	}
}
