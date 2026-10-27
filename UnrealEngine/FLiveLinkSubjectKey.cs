using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200221A RID: 8730
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSubjectKey")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FLiveLinkSubjectKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213FD RID: 136189 RVA: 0x003103AF File Offset: 0x0030E5AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSubjectKey._ScriptStructPtr != 0) ? FLiveLinkSubjectKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSubjectKey", ref FLiveLinkSubjectKey._ScriptStructPtr);
		}

		// Token: 0x170081C9 RID: 33225
		// (get) Token: 0x060213FE RID: 136190 RVA: 0x003103D3 File Offset: 0x0030E5D3
		// (set) Token: 0x060213FF RID: 136191 RVA: 0x003103E7 File Offset: 0x0030E5E7
		public unsafe FGuid Source
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSubjectKey.__PropertyOffset_Source);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSubjectKey.__PropertyOffset_Source) = value;
			}
		}

		// Token: 0x170081CA RID: 33226
		// (get) Token: 0x06021400 RID: 136192 RVA: 0x003103FC File Offset: 0x0030E5FC
		// (set) Token: 0x06021401 RID: 136193 RVA: 0x0031043F File Offset: 0x0030E63F
		public FLiveLinkSubjectName SubjectName
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkSubjectName result;
				if ((result = this._SubjectName) == null)
				{
					result = (this._SubjectName = new FLiveLinkSubjectName(base.NativePtr + (IntPtr)FLiveLinkSubjectKey.__PropertyOffset_SubjectName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkSubjectName.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkSubjectKey.__PropertyOffset_SubjectName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021402 RID: 136194 RVA: 0x00310460 File Offset: 0x0030E660
		public FLiveLinkSubjectKey()
		{
		}

		// Token: 0x06021403 RID: 136195 RVA: 0x00310468 File Offset: 0x0030E668
		public FLiveLinkSubjectKey(FGuid Source, FLiveLinkSubjectName SubjectName)
		{
			this.Source = Source;
			this.SubjectName = SubjectName;
		}

		// Token: 0x06021404 RID: 136196 RVA: 0x0031047E File Offset: 0x0030E67E
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSubjectKey.StaticStruct();
		}

		// Token: 0x06021405 RID: 136197 RVA: 0x0031048A File Offset: 0x0030E68A
		[NullableContext(2)]
		public FLiveLinkSubjectKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021406 RID: 136198 RVA: 0x00310494 File Offset: 0x0030E694
		public FLiveLinkSubjectKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021407 RID: 136199 RVA: 0x0031049F File Offset: 0x0030E69F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSubjectKey(Pointer, false, true);
		}

		// Token: 0x06021408 RID: 136200 RVA: 0x003104A9 File Offset: 0x0030E6A9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSubjectKey(Pointer, MemoryOwner);
		}

		// Token: 0x04011BC4 RID: 72644
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSubjectKey";

		// Token: 0x04011BC5 RID: 72645
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BC6 RID: 72646
		internal static int __PropertyOffset_Source;

		// Token: 0x04011BC7 RID: 72647
		internal static int __PropertyOffset_SubjectName;

		// Token: 0x04011BC8 RID: 72648
		[Nullable(2)]
		private FLiveLinkSubjectName _SubjectName;
	}
}
