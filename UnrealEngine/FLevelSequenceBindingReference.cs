using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB3 RID: 8115
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceBindingReference")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLevelSequenceBindingReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601ECE8 RID: 126184 RVA: 0x002DC9CC File Offset: 0x002DABCC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelSequenceBindingReference._ScriptStructPtr != 0) ? FLevelSequenceBindingReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LevelSequence.LevelSequenceBindingReference", ref FLevelSequenceBindingReference._ScriptStructPtr);
		}

		// Token: 0x17007AB0 RID: 31408
		// (get) Token: 0x0601ECE9 RID: 126185 RVA: 0x002DC9F0 File Offset: 0x002DABF0
		// (set) Token: 0x0601ECEA RID: 126186 RVA: 0x002DCA04 File Offset: 0x002DAC04
		public unsafe string PackageName_DEPRECATED
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequenceBindingReference.__PropertyOffset_PackageName_DEPRECATED)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequenceBindingReference.__PropertyOffset_PackageName_DEPRECATED)), value);
			}
		}

		// Token: 0x17007AB1 RID: 31409
		// (get) Token: 0x0601ECEB RID: 126187 RVA: 0x002DCA1C File Offset: 0x002DAC1C
		// (set) Token: 0x0601ECEC RID: 126188 RVA: 0x002DCA5F File Offset: 0x002DAC5F
		public FSoftObjectPath ExternalObjectPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ExternalObjectPath) == null)
				{
					result = (this._ExternalObjectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)FLevelSequenceBindingReference.__PropertyOffset_ExternalObjectPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FLevelSequenceBindingReference.__PropertyOffset_ExternalObjectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007AB2 RID: 31410
		// (get) Token: 0x0601ECED RID: 126189 RVA: 0x002DCA80 File Offset: 0x002DAC80
		// (set) Token: 0x0601ECEE RID: 126190 RVA: 0x002DCA94 File Offset: 0x002DAC94
		public unsafe string ObjectPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequenceBindingReference.__PropertyOffset_ObjectPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLevelSequenceBindingReference.__PropertyOffset_ObjectPath)), value);
			}
		}

		// Token: 0x0601ECEF RID: 126191 RVA: 0x002DCAA9 File Offset: 0x002DACA9
		public FLevelSequenceBindingReference()
		{
		}

		// Token: 0x0601ECF0 RID: 126192 RVA: 0x002DCAB1 File Offset: 0x002DACB1
		public FLevelSequenceBindingReference(string PackageName_DEPRECATED, FSoftObjectPath ExternalObjectPath, string ObjectPath, string ExternalAssetPath)
		{
			this.PackageName_DEPRECATED = PackageName_DEPRECATED;
			this.ExternalObjectPath = ExternalObjectPath;
			this.ObjectPath = ObjectPath;
		}

		// Token: 0x0601ECF1 RID: 126193 RVA: 0x002DCACE File Offset: 0x002DACCE
		protected override IntPtr GetUStructPtr()
		{
			return FLevelSequenceBindingReference.StaticStruct();
		}

		// Token: 0x0601ECF2 RID: 126194 RVA: 0x002DCADA File Offset: 0x002DACDA
		[NullableContext(2)]
		public FLevelSequenceBindingReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601ECF3 RID: 126195 RVA: 0x002DCAE4 File Offset: 0x002DACE4
		public FLevelSequenceBindingReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601ECF4 RID: 126196 RVA: 0x002DCAEF File Offset: 0x002DACEF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelSequenceBindingReference(Pointer, false, true);
		}

		// Token: 0x0601ECF5 RID: 126197 RVA: 0x002DCAF9 File Offset: 0x002DACF9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelSequenceBindingReference(Pointer, MemoryOwner);
		}

		// Token: 0x04010A6B RID: 68203
		public const string __ObjectPath = "/Script/LevelSequence.LevelSequenceBindingReference";

		// Token: 0x04010A6C RID: 68204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A6D RID: 68205
		internal static int __PropertyOffset_PackageName_DEPRECATED;

		// Token: 0x04010A6E RID: 68206
		internal static int __PropertyOffset_ExternalObjectPath;

		// Token: 0x04010A6F RID: 68207
		[Nullable(2)]
		private FSoftObjectPath _ExternalObjectPath;

		// Token: 0x04010A70 RID: 68208
		internal static int __PropertyOffset_ObjectPath;
	}
}
