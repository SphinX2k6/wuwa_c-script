using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029C5 RID: 10693
	[UnrealObjectPath("/Script/UMG.RadialBoxSettings")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FRadialBoxSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027865 RID: 161893 RVA: 0x003C50DE File Offset: 0x003C32DE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRadialBoxSettings._ScriptStructPtr != 0) ? FRadialBoxSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.RadialBoxSettings", ref FRadialBoxSettings._ScriptStructPtr);
		}

		// Token: 0x1700977B RID: 38779
		// (get) Token: 0x06027866 RID: 161894 RVA: 0x003C5102 File Offset: 0x003C3302
		// (set) Token: 0x06027867 RID: 161895 RVA: 0x003C5112 File Offset: 0x003C3312
		public unsafe bool bDistributeItemsEvenly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialBoxSettings.__PropertyOffset_bDistributeItemsEvenly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialBoxSettings.__PropertyOffset_bDistributeItemsEvenly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700977C RID: 38780
		// (get) Token: 0x06027868 RID: 161896 RVA: 0x003C5123 File Offset: 0x003C3323
		// (set) Token: 0x06027869 RID: 161897 RVA: 0x003C5133 File Offset: 0x003C3333
		public unsafe float AngleBetweenItems
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialBoxSettings.__PropertyOffset_AngleBetweenItems);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialBoxSettings.__PropertyOffset_AngleBetweenItems) = value;
			}
		}

		// Token: 0x1700977D RID: 38781
		// (get) Token: 0x0602786A RID: 161898 RVA: 0x003C5144 File Offset: 0x003C3344
		// (set) Token: 0x0602786B RID: 161899 RVA: 0x003C5154 File Offset: 0x003C3354
		public unsafe float StartingAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRadialBoxSettings.__PropertyOffset_StartingAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRadialBoxSettings.__PropertyOffset_StartingAngle) = value;
			}
		}

		// Token: 0x0602786C RID: 161900 RVA: 0x003C5165 File Offset: 0x003C3365
		public FRadialBoxSettings()
		{
		}

		// Token: 0x0602786D RID: 161901 RVA: 0x003C516D File Offset: 0x003C336D
		public FRadialBoxSettings(bool bDistributeItemsEvenly, float AngleBetweenItems, float StartingAngle)
		{
			this.bDistributeItemsEvenly = bDistributeItemsEvenly;
			this.AngleBetweenItems = AngleBetweenItems;
			this.StartingAngle = StartingAngle;
		}

		// Token: 0x0602786E RID: 161902 RVA: 0x003C518A File Offset: 0x003C338A
		protected override IntPtr GetUStructPtr()
		{
			return FRadialBoxSettings.StaticStruct();
		}

		// Token: 0x0602786F RID: 161903 RVA: 0x003C5196 File Offset: 0x003C3396
		[NullableContext(2)]
		public FRadialBoxSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027870 RID: 161904 RVA: 0x003C51A0 File Offset: 0x003C33A0
		public FRadialBoxSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027871 RID: 161905 RVA: 0x003C51AB File Offset: 0x003C33AB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRadialBoxSettings(Pointer, false, true);
		}

		// Token: 0x06027872 RID: 161906 RVA: 0x003C51B5 File Offset: 0x003C33B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRadialBoxSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04015ABC RID: 88764
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.RadialBoxSettings";

		// Token: 0x04015ABD RID: 88765
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015ABE RID: 88766
		internal static int __PropertyOffset_bDistributeItemsEvenly;

		// Token: 0x04015ABF RID: 88767
		internal static int __PropertyOffset_AngleBetweenItems;

		// Token: 0x04015AC0 RID: 88768
		internal static int __PropertyOffset_StartingAngle;
	}
}
