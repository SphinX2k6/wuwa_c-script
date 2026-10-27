using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020EB RID: 8427
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LoadingPathRenderableMap")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLoadingPathRenderableMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FBBB RID: 129979 RVA: 0x002F2DBA File Offset: 0x002F0FBA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLoadingPathRenderableMap._ScriptStructPtr != 0) ? FLoadingPathRenderableMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LoadingPathRenderableMap", ref FLoadingPathRenderableMap._ScriptStructPtr);
		}

		// Token: 0x17007CF1 RID: 31985
		// (get) Token: 0x0601FBBC RID: 129980 RVA: 0x002F2DE0 File Offset: 0x002F0FE0
		// (set) Token: 0x0601FBBD RID: 129981 RVA: 0x002F2E23 File Offset: 0x002F1023
		public TMap<FSoftObjectPath, FRenderableCollection> LoadingPathRenderableMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FRenderableCollection> result;
				if ((result = this._LoadingPathRenderableMap) == null)
				{
					result = (this._LoadingPathRenderableMap = new TMap<FSoftObjectPath, FRenderableCollection>(base.NativePtr + (IntPtr)FLoadingPathRenderableMap.__PropertyOffset_LoadingPathRenderableMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LoadingPathRenderableMap.CopyAssign(value);
			}
		}

		// Token: 0x0601FBBE RID: 129982 RVA: 0x002F2E31 File Offset: 0x002F1031
		public FLoadingPathRenderableMap()
		{
		}

		// Token: 0x0601FBBF RID: 129983 RVA: 0x002F2E39 File Offset: 0x002F1039
		public FLoadingPathRenderableMap(TMap<FSoftObjectPath, FRenderableCollection> LoadingPathRenderableMap)
		{
			this.LoadingPathRenderableMap = LoadingPathRenderableMap;
		}

		// Token: 0x0601FBC0 RID: 129984 RVA: 0x002F2E48 File Offset: 0x002F1048
		protected override IntPtr GetUStructPtr()
		{
			return FLoadingPathRenderableMap.StaticStruct();
		}

		// Token: 0x0601FBC1 RID: 129985 RVA: 0x002F2E54 File Offset: 0x002F1054
		[NullableContext(2)]
		public FLoadingPathRenderableMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBC2 RID: 129986 RVA: 0x002F2E5E File Offset: 0x002F105E
		public FLoadingPathRenderableMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBC3 RID: 129987 RVA: 0x002F2E69 File Offset: 0x002F1069
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLoadingPathRenderableMap(Pointer, false, true);
		}

		// Token: 0x0601FBC4 RID: 129988 RVA: 0x002F2E73 File Offset: 0x002F1073
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLoadingPathRenderableMap(Pointer, MemoryOwner);
		}

		// Token: 0x040111B9 RID: 70073
		public const string __ObjectPath = "/Script/LGUI.LoadingPathRenderableMap";

		// Token: 0x040111BA RID: 70074
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111BB RID: 70075
		internal static int __PropertyOffset_LoadingPathRenderableMap;

		// Token: 0x040111BC RID: 70076
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, FRenderableCollection> _LoadingPathRenderableMap;
	}
}
