using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FF RID: 2047
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimCurveBase")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAnimCurveBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D46 RID: 27974 RVA: 0x0009D4B9 File Offset: 0x0009B6B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimCurveBase._ScriptStructPtr != 0) ? FAnimCurveBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimCurveBase", ref FAnimCurveBase._ScriptStructPtr);
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x0009D4DD File Offset: 0x0009B6DD
		// (set) Token: 0x06006D48 RID: 27976 RVA: 0x0009D4F1 File Offset: 0x0009B6F1
		public unsafe FName LastObservedName_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimCurveBase.__PropertyOffset_LastObservedName_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimCurveBase.__PropertyOffset_LastObservedName_DEPRECATED) = value;
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x0009D508 File Offset: 0x0009B708
		// (set) Token: 0x06006D4A RID: 27978 RVA: 0x0009D54B File Offset: 0x0009B74B
		public FSmartName Name
		{
			get
			{
				base.FastCheckIsValid();
				FSmartName result;
				if ((result = this._Name) == null)
				{
					result = (this._Name = new FSmartName(base.NativePtr + (IntPtr)FAnimCurveBase.__PropertyOffset_Name, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSmartName.StaticStruct(), base.NativePtr + (IntPtr)FAnimCurveBase.__PropertyOffset_Name, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06006D4B RID: 27979 RVA: 0x0009D56C File Offset: 0x0009B76C
		// (set) Token: 0x06006D4C RID: 27980 RVA: 0x0009D57C File Offset: 0x0009B77C
		public unsafe int CurveTypeFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimCurveBase.__PropertyOffset_CurveTypeFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimCurveBase.__PropertyOffset_CurveTypeFlags) = value;
			}
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x0009D58D File Offset: 0x0009B78D
		public FAnimCurveBase()
		{
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x0009D595 File Offset: 0x0009B795
		public FAnimCurveBase(FName LastObservedName_DEPRECATED, FSmartName Name, FLinearColor Color, int CurveTypeFlags)
		{
			this.LastObservedName_DEPRECATED = LastObservedName_DEPRECATED;
			this.Name = Name;
			this.CurveTypeFlags = CurveTypeFlags;
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x0009D5B3 File Offset: 0x0009B7B3
		protected override IntPtr GetUStructPtr()
		{
			return FAnimCurveBase.StaticStruct();
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x0009D5BF File Offset: 0x0009B7BF
		[NullableContext(2)]
		public FAnimCurveBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x0009D5C9 File Offset: 0x0009B7C9
		public FAnimCurveBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x0009D5D4 File Offset: 0x0009B7D4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimCurveBase(Pointer, false, true);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x0009D5DE File Offset: 0x0009B7DE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimCurveBase(Pointer, MemoryOwner);
		}

		// Token: 0x040034C9 RID: 13513
		public const string __ObjectPath = "/Script/Engine.AnimCurveBase";

		// Token: 0x040034CA RID: 13514
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040034CB RID: 13515
		internal static int __PropertyOffset_LastObservedName_DEPRECATED;

		// Token: 0x040034CC RID: 13516
		internal static int __PropertyOffset_Name;

		// Token: 0x040034CD RID: 13517
		[Nullable(2)]
		private FSmartName _Name;

		// Token: 0x040034CE RID: 13518
		internal static int __PropertyOffset_CurveTypeFlags;
	}
}
