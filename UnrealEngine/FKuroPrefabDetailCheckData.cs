using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D04 RID: 3332
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroPrefabDetailCheckData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroPrefabDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B167 RID: 45415 RVA: 0x000FBD03 File Offset: 0x000F9F03
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPrefabDetailCheckData._ScriptStructPtr != 0) ? FKuroPrefabDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroPrefabDetailCheckData", ref FKuroPrefabDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600B168 RID: 45416 RVA: 0x000FBD27 File Offset: 0x000F9F27
		// (set) Token: 0x0600B169 RID: 45417 RVA: 0x000FBD3B File Offset: 0x000F9F3B
		public unsafe string prefab_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroPrefabDetailCheckData.__PropertyOffset_prefab_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroPrefabDetailCheckData.__PropertyOffset_prefab_path)), value);
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x0600B16A RID: 45418 RVA: 0x000FBD50 File Offset: 0x000F9F50
		// (set) Token: 0x0600B16B RID: 45419 RVA: 0x000FBD93 File Offset: 0x000F9F93
		public TArray<string> prefab_model_path
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._prefab_model_path) == null)
				{
					result = (this._prefab_model_path = new TArray<string>(base.NativePtr + (IntPtr)FKuroPrefabDetailCheckData.__PropertyOffset_prefab_model_path, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.prefab_model_path.CopyAssign(value);
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x0600B16C RID: 45420 RVA: 0x000FBDA1 File Offset: 0x000F9FA1
		// (set) Token: 0x0600B16D RID: 45421 RVA: 0x000FBDB5 File Offset: 0x000F9FB5
		public unsafe string PrefabModelPathString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroPrefabDetailCheckData.__PropertyOffset_PrefabModelPathString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroPrefabDetailCheckData.__PropertyOffset_PrefabModelPathString)), value);
			}
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x000FBDCA File Offset: 0x000F9FCA
		public FKuroPrefabDetailCheckData()
		{
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x000FBDD2 File Offset: 0x000F9FD2
		public FKuroPrefabDetailCheckData(string prefab_path, TArray<string> prefab_model_path, string PrefabModelPathString)
		{
			this.prefab_path = prefab_path;
			this.prefab_model_path = prefab_model_path;
			this.PrefabModelPathString = PrefabModelPathString;
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x000FBDEF File Offset: 0x000F9FEF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPrefabDetailCheckData.StaticStruct();
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x000FBDFB File Offset: 0x000F9FFB
		[NullableContext(2)]
		public FKuroPrefabDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x000FBE05 File Offset: 0x000FA005
		public FKuroPrefabDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x000FBE10 File Offset: 0x000FA010
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPrefabDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x000FBE1A File Offset: 0x000FA01A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPrefabDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005CE5 RID: 23781
		public const string __ObjectPath = "/Script/Engine.KuroPrefabDetailCheckData";

		// Token: 0x04005CE6 RID: 23782
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CE7 RID: 23783
		internal static int __PropertyOffset_prefab_path;

		// Token: 0x04005CE8 RID: 23784
		internal static int __PropertyOffset_prefab_model_path;

		// Token: 0x04005CE9 RID: 23785
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _prefab_model_path;

		// Token: 0x04005CEA RID: 23786
		internal static int __PropertyOffset_PrefabModelPathString;
	}
}
