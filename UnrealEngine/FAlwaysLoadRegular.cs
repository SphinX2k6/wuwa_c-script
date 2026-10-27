using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007D7 RID: 2007
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AlwaysLoadRegular")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAlwaysLoadRegular : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006AEB RID: 27371 RVA: 0x0009A079 File Offset: 0x00098279
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAlwaysLoadRegular._ScriptStructPtr != 0) ? FAlwaysLoadRegular._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AlwaysLoadRegular", ref FAlwaysLoadRegular._ScriptStructPtr);
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06006AEC RID: 27372 RVA: 0x0009A09D File Offset: 0x0009829D
		// (set) Token: 0x06006AED RID: 27373 RVA: 0x0009A0B1 File Offset: 0x000982B1
		public unsafe string FolderRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAlwaysLoadRegular.__PropertyOffset_FolderRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAlwaysLoadRegular.__PropertyOffset_FolderRegex)), value);
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06006AEE RID: 27374 RVA: 0x0009A0C8 File Offset: 0x000982C8
		// (set) Token: 0x06006AEF RID: 27375 RVA: 0x0009A10B File Offset: 0x0009830B
		public TArray<string> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<string>(base.NativePtr + (IntPtr)FAlwaysLoadRegular.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x0009A119 File Offset: 0x00098319
		public FAlwaysLoadRegular()
		{
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x0009A121 File Offset: 0x00098321
		public FAlwaysLoadRegular(string FolderRegex, TArray<string> DataLayers)
		{
			this.FolderRegex = FolderRegex;
			this.DataLayers = DataLayers;
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0009A137 File Offset: 0x00098337
		protected override IntPtr GetUStructPtr()
		{
			return FAlwaysLoadRegular.StaticStruct();
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x0009A143 File Offset: 0x00098343
		[NullableContext(2)]
		public FAlwaysLoadRegular(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x0009A14D File Offset: 0x0009834D
		public FAlwaysLoadRegular(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x0009A158 File Offset: 0x00098358
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAlwaysLoadRegular(Pointer, false, true);
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x0009A162 File Offset: 0x00098362
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAlwaysLoadRegular(Pointer, MemoryOwner);
		}

		// Token: 0x04003376 RID: 13174
		public const string __ObjectPath = "/Script/Engine.AlwaysLoadRegular";

		// Token: 0x04003377 RID: 13175
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003378 RID: 13176
		internal static int __PropertyOffset_FolderRegex;

		// Token: 0x04003379 RID: 13177
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x0400337A RID: 13178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DataLayers;
	}
}
