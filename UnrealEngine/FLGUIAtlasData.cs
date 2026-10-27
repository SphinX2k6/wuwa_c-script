using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200201D RID: 8221
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIAtlasData")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FLGUIAtlasData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EF98 RID: 126872 RVA: 0x002E1009 File Offset: 0x002DF209
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIAtlasData._ScriptStructPtr != 0) ? FLGUIAtlasData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIAtlasData", ref FLGUIAtlasData._ScriptStructPtr);
		}

		// Token: 0x17007B4A RID: 31562
		// (get) Token: 0x0601EF99 RID: 126873 RVA: 0x002E1030 File Offset: 0x002DF230
		// (set) Token: 0x0601EF9A RID: 126874 RVA: 0x002E1073 File Offset: 0x002DF273
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUISpriteBase>> renderSpriteArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUISpriteBase>> result;
				if ((result = this._renderSpriteArray) == null)
				{
					result = (this._renderSpriteArray = new TArray<TWeakObjectPtr<UUISpriteBase>>(base.NativePtr + (IntPtr)FLGUIAtlasData.__PropertyOffset_renderSpriteArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.renderSpriteArray.CopyAssign(value);
			}
		}

		// Token: 0x17007B4B RID: 31563
		// (get) Token: 0x0601EF9B RID: 126875 RVA: 0x002E1081 File Offset: 0x002DF281
		// (set) Token: 0x0601EF9C RID: 126876 RVA: 0x002E1095 File Offset: 0x002DF295
		[Nullable(2)]
		public unsafe UTexture2D atlasTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIAtlasData.__PropertyOffset_atlasTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIAtlasData.__PropertyOffset_atlasTexture, value);
			}
		}

		// Token: 0x17007B4C RID: 31564
		// (get) Token: 0x0601EF9D RID: 126877 RVA: 0x002E10AC File Offset: 0x002DF2AC
		// (set) Token: 0x0601EF9E RID: 126878 RVA: 0x002E10EF File Offset: 0x002DF2EF
		public TArray<ULGUISpriteData> spriteDataArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUISpriteData> result;
				if ((result = this._spriteDataArray) == null)
				{
					result = (this._spriteDataArray = new TArray<ULGUISpriteData>(base.NativePtr + (IntPtr)FLGUIAtlasData.__PropertyOffset_spriteDataArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.spriteDataArray.CopyAssign(value);
			}
		}

		// Token: 0x0601EF9F RID: 126879 RVA: 0x002E10FD File Offset: 0x002DF2FD
		public FLGUIAtlasData()
		{
		}

		// Token: 0x0601EFA0 RID: 126880 RVA: 0x002E1105 File Offset: 0x002DF305
		public FLGUIAtlasData([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<UUISpriteBase>> renderSpriteArray, UTexture2D atlasTexture, TArray<ULGUISpriteData> spriteDataArray)
		{
			this.renderSpriteArray = renderSpriteArray;
			this.atlasTexture = atlasTexture;
			this.spriteDataArray = spriteDataArray;
		}

		// Token: 0x0601EFA1 RID: 126881 RVA: 0x002E1122 File Offset: 0x002DF322
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIAtlasData.StaticStruct();
		}

		// Token: 0x0601EFA2 RID: 126882 RVA: 0x002E112E File Offset: 0x002DF32E
		[NullableContext(2)]
		public FLGUIAtlasData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFA3 RID: 126883 RVA: 0x002E1138 File Offset: 0x002DF338
		public FLGUIAtlasData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFA4 RID: 126884 RVA: 0x002E1143 File Offset: 0x002DF343
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIAtlasData(Pointer, false, true);
		}

		// Token: 0x0601EFA5 RID: 126885 RVA: 0x002E114D File Offset: 0x002DF34D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIAtlasData(Pointer, MemoryOwner);
		}

		// Token: 0x04010D6C RID: 68972
		public const string __ObjectPath = "/Script/LGUI.LGUIAtlasData";

		// Token: 0x04010D6D RID: 68973
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D6E RID: 68974
		internal static int __PropertyOffset_renderSpriteArray;

		// Token: 0x04010D6F RID: 68975
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUISpriteBase>> _renderSpriteArray;

		// Token: 0x04010D70 RID: 68976
		internal static int __PropertyOffset_atlasTexture;

		// Token: 0x04010D71 RID: 68977
		internal static int __PropertyOffset_spriteDataArray;

		// Token: 0x04010D72 RID: 68978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUISpriteData> _spriteDataArray;
	}
}
