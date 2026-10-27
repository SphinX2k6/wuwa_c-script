using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200086D RID: 2157
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AudioQualitySettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAudioQualitySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007515 RID: 29973 RVA: 0x000A7D15 File Offset: 0x000A5F15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioQualitySettings._ScriptStructPtr != 0) ? FAudioQualitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioQualitySettings", ref FAudioQualitySettings._ScriptStructPtr);
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06007516 RID: 29974 RVA: 0x000A7D3C File Offset: 0x000A5F3C
		// (set) Token: 0x06007517 RID: 29975 RVA: 0x000A7D7F File Offset: 0x000A5F7F
		public unsafe FText DisplayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName) == null)
				{
					result = (this._DisplayName = new FText(base.NativePtr + (IntPtr)FAudioQualitySettings.__PropertyOffset_DisplayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FAudioQualitySettings.__PropertyOffset_DisplayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x000A7D9A File Offset: 0x000A5F9A
		// (set) Token: 0x06007519 RID: 29977 RVA: 0x000A7DAA File Offset: 0x000A5FAA
		public unsafe int MaxChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioQualitySettings.__PropertyOffset_MaxChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioQualitySettings.__PropertyOffset_MaxChannels) = value;
			}
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x000A7DBB File Offset: 0x000A5FBB
		public FAudioQualitySettings()
		{
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x000A7DC3 File Offset: 0x000A5FC3
		public FAudioQualitySettings(FText DisplayName, int MaxChannels)
		{
			this.DisplayName = DisplayName;
			this.MaxChannels = MaxChannels;
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x000A7DD9 File Offset: 0x000A5FD9
		protected override IntPtr GetUStructPtr()
		{
			return FAudioQualitySettings.StaticStruct();
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x000A7DE5 File Offset: 0x000A5FE5
		[NullableContext(2)]
		public FAudioQualitySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x000A7DEF File Offset: 0x000A5FEF
		public FAudioQualitySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x000A7DFA File Offset: 0x000A5FFA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioQualitySettings(Pointer, false, true);
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x000A7E04 File Offset: 0x000A6004
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioQualitySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003848 RID: 14408
		public const string __ObjectPath = "/Script/Engine.AudioQualitySettings";

		// Token: 0x04003849 RID: 14409
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400384A RID: 14410
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x0400384B RID: 14411
		[Nullable(2)]
		private FText _DisplayName;

		// Token: 0x0400384C RID: 14412
		internal static int __PropertyOffset_MaxChannels;
	}
}
