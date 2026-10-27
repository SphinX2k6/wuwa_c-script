using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007CE RID: 1998
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AddDataLayerSubItem")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAddDataLayerSubItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006A8B RID: 27275 RVA: 0x000998B8 File Offset: 0x00097AB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAddDataLayerSubItem._ScriptStructPtr != 0) ? FAddDataLayerSubItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AddDataLayerSubItem", ref FAddDataLayerSubItem._ScriptStructPtr);
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x06006A8C RID: 27276 RVA: 0x000998DC File Offset: 0x00097ADC
		// (set) Token: 0x06006A8D RID: 27277 RVA: 0x000998F0 File Offset: 0x00097AF0
		public unsafe string FolderRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAddDataLayerSubItem.__PropertyOffset_FolderRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAddDataLayerSubItem.__PropertyOffset_FolderRegex)), value);
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x00099908 File Offset: 0x00097B08
		// (set) Token: 0x06006A8F RID: 27279 RVA: 0x0009994B File Offset: 0x00097B4B
		public TArray<string> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<string>(base.NativePtr + (IntPtr)FAddDataLayerSubItem.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00099959 File Offset: 0x00097B59
		public FAddDataLayerSubItem()
		{
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x00099961 File Offset: 0x00097B61
		public FAddDataLayerSubItem(string FolderRegex, TArray<string> DataLayers)
		{
			this.FolderRegex = FolderRegex;
			this.DataLayers = DataLayers;
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x00099977 File Offset: 0x00097B77
		protected override IntPtr GetUStructPtr()
		{
			return FAddDataLayerSubItem.StaticStruct();
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00099983 File Offset: 0x00097B83
		[NullableContext(2)]
		public FAddDataLayerSubItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x0009998D File Offset: 0x00097B8D
		public FAddDataLayerSubItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x00099998 File Offset: 0x00097B98
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAddDataLayerSubItem(Pointer, false, true);
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x000999A2 File Offset: 0x00097BA2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAddDataLayerSubItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400334A RID: 13130
		public const string __ObjectPath = "/Script/Engine.AddDataLayerSubItem";

		// Token: 0x0400334B RID: 13131
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400334C RID: 13132
		internal static int __PropertyOffset_FolderRegex;

		// Token: 0x0400334D RID: 13133
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x0400334E RID: 13134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DataLayers;
	}
}
