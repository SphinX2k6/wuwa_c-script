using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200079A RID: 1946
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineSettings.GameModeName")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGameModeName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600655C RID: 25948 RVA: 0x000915C9 File Offset: 0x0008F7C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameModeName._ScriptStructPtr != 0) ? FGameModeName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineSettings.GameModeName", ref FGameModeName._ScriptStructPtr);
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x000915ED File Offset: 0x0008F7ED
		// (set) Token: 0x0600655E RID: 25950 RVA: 0x00091601 File Offset: 0x0008F801
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGameModeName.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGameModeName.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x0600655F RID: 25951 RVA: 0x00091618 File Offset: 0x0008F818
		// (set) Token: 0x06006560 RID: 25952 RVA: 0x0009165B File Offset: 0x0008F85B
		public FSoftClassPath GameMode
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GameMode) == null)
				{
					result = (this._GameMode = new FSoftClassPath(base.NativePtr + (IntPtr)FGameModeName.__PropertyOffset_GameMode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)FGameModeName.__PropertyOffset_GameMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x0009167C File Offset: 0x0008F87C
		public FGameModeName()
		{
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x00091684 File Offset: 0x0008F884
		public FGameModeName(string Name, FSoftClassPath GameMode)
		{
			this.Name = Name;
			this.GameMode = GameMode;
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x0009169A File Offset: 0x0008F89A
		protected override IntPtr GetUStructPtr()
		{
			return FGameModeName.StaticStruct();
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x000916A6 File Offset: 0x0008F8A6
		[NullableContext(2)]
		public FGameModeName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x000916B0 File Offset: 0x0008F8B0
		public FGameModeName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x000916BB File Offset: 0x0008F8BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameModeName(Pointer, false, true);
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x000916C5 File Offset: 0x0008F8C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameModeName(Pointer, MemoryOwner);
		}

		// Token: 0x0400312F RID: 12591
		public const string __ObjectPath = "/Script/EngineSettings.GameModeName";

		// Token: 0x04003130 RID: 12592
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003131 RID: 12593
		internal static int __PropertyOffset_Name;

		// Token: 0x04003132 RID: 12594
		internal static int __PropertyOffset_GameMode;

		// Token: 0x04003133 RID: 12595
		[Nullable(2)]
		private FSoftClassPath _GameMode;
	}
}
