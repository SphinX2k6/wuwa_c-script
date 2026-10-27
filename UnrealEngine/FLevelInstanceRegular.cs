using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D30 RID: 3376
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelInstanceRegular")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLevelInstanceRegular : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B4D3 RID: 46291 RVA: 0x00101F46 File Offset: 0x00100146
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelInstanceRegular._ScriptStructPtr != 0) ? FLevelInstanceRegular._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LevelInstanceRegular", ref FLevelInstanceRegular._ScriptStructPtr);
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x0600B4D4 RID: 46292 RVA: 0x00101F6A File Offset: 0x0010016A
		// (set) Token: 0x0600B4D5 RID: 46293 RVA: 0x00101F7E File Offset: 0x0010017E
		public unsafe string FolderRegex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelInstanceRegular.__PropertyOffset_FolderRegex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelInstanceRegular.__PropertyOffset_FolderRegex)), value);
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x0600B4D6 RID: 46294 RVA: 0x00101F94 File Offset: 0x00100194
		// (set) Token: 0x0600B4D7 RID: 46295 RVA: 0x00101FD7 File Offset: 0x001001D7
		public TArray<string> SpecifiedClassName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SpecifiedClassName) == null)
				{
					result = (this._SpecifiedClassName = new TArray<string>(base.NativePtr + (IntPtr)FLevelInstanceRegular.__PropertyOffset_SpecifiedClassName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecifiedClassName.CopyAssign(value);
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x0600B4D8 RID: 46296 RVA: 0x00101FE8 File Offset: 0x001001E8
		// (set) Token: 0x0600B4D9 RID: 46297 RVA: 0x0010202B File Offset: 0x0010022B
		public TArray<string> DataLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DataLayers) == null)
				{
					result = (this._DataLayers = new TArray<string>(base.NativePtr + (IntPtr)FLevelInstanceRegular.__PropertyOffset_DataLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayers.CopyAssign(value);
			}
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x00102039 File Offset: 0x00100239
		public FLevelInstanceRegular()
		{
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x00102041 File Offset: 0x00100241
		public FLevelInstanceRegular(string FolderRegex, TArray<string> SpecifiedClassName, TArray<string> DataLayers)
		{
			this.FolderRegex = FolderRegex;
			this.SpecifiedClassName = SpecifiedClassName;
			this.DataLayers = DataLayers;
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x0010205E File Offset: 0x0010025E
		protected override IntPtr GetUStructPtr()
		{
			return FLevelInstanceRegular.StaticStruct();
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x0010206A File Offset: 0x0010026A
		[NullableContext(2)]
		public FLevelInstanceRegular(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x00102074 File Offset: 0x00100274
		public FLevelInstanceRegular(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x0010207F File Offset: 0x0010027F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelInstanceRegular(Pointer, false, true);
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x00102089 File Offset: 0x00100289
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelInstanceRegular(Pointer, MemoryOwner);
		}

		// Token: 0x04005F10 RID: 24336
		public const string __ObjectPath = "/Script/Engine.LevelInstanceRegular";

		// Token: 0x04005F11 RID: 24337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005F12 RID: 24338
		internal static int __PropertyOffset_FolderRegex;

		// Token: 0x04005F13 RID: 24339
		internal static int __PropertyOffset_SpecifiedClassName;

		// Token: 0x04005F14 RID: 24340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SpecifiedClassName;

		// Token: 0x04005F15 RID: 24341
		internal static int __PropertyOffset_DataLayers;

		// Token: 0x04005F16 RID: 24342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DataLayers;
	}
}
