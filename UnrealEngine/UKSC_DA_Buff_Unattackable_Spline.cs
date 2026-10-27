using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D86 RID: 7558
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Unattackable_Spline")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_DA_Buff_Unattackable_Spline : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF05 RID: 118533 RVA: 0x002AC632 File Offset: 0x002AA832
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Unattackable_Spline._ClassPtr;
		}

		// Token: 0x0601CF06 RID: 118534 RVA: 0x002AC640 File Offset: 0x002AA840
		public UKSC_DA_Buff_Unattackable_Spline() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Unattackable_Spline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF07 RID: 118535 RVA: 0x002AC668 File Offset: 0x002AA868
		public UKSC_DA_Buff_Unattackable_Spline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Unattackable_Spline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074B8 RID: 29880
		// (get) Token: 0x0601CF08 RID: 118536 RVA: 0x002AC69B File Offset: 0x002AA89B
		// (set) Token: 0x0601CF09 RID: 118537 RVA: 0x002AC6AB File Offset: 0x002AA8AB
		public unsafe float InputKeyOver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Unattackable_Spline.__PropertyOffset_InputKeyOver);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Unattackable_Spline.__PropertyOffset_InputKeyOver) = value;
			}
		}

		// Token: 0x170074B9 RID: 29881
		// (get) Token: 0x0601CF0A RID: 118538 RVA: 0x002AC6BC File Offset: 0x002AA8BC
		// (set) Token: 0x0601CF0B RID: 118539 RVA: 0x002AC6F5 File Offset: 0x002AA8F5
		public FGameplayTagContainer InvisibleTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._InvisibleTags) == null)
				{
					result = (this._InvisibleTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_Unattackable_Spline.__PropertyOffset_InvisibleTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Unattackable_Spline.__PropertyOffset_InvisibleTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170074BA RID: 29882
		// (get) Token: 0x0601CF0C RID: 118540 RVA: 0x002AC718 File Offset: 0x002AA918
		// (set) Token: 0x0601CF0D RID: 118541 RVA: 0x002AC751 File Offset: 0x002AA951
		public FGameplayTagContainer ImmuneBuffTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ImmuneBuffTags) == null)
				{
					result = (this._ImmuneBuffTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_Unattackable_Spline.__PropertyOffset_ImmuneBuffTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_Unattackable_Spline.__PropertyOffset_ImmuneBuffTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601CF0E RID: 118542 RVA: 0x002AC772 File Offset: 0x002AA972
		static UKSC_DA_Buff_Unattackable_Spline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Unattackable_Spline");
		}

		// Token: 0x0601CF0F RID: 118543 RVA: 0x002AC780 File Offset: 0x002AA980
		protected UKSC_DA_Buff_Unattackable_Spline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB46 RID: 64326
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Unattackable_Spline";

		// Token: 0x0400FB47 RID: 64327
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB48 RID: 64328
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB49 RID: 64329
		internal static int __PropertyOffset_InputKeyOver;

		// Token: 0x0400FB4A RID: 64330
		internal static int __PropertyOffset_InvisibleTags;

		// Token: 0x0400FB4B RID: 64331
		[Nullable(2)]
		private FGameplayTagContainer _InvisibleTags;

		// Token: 0x0400FB4C RID: 64332
		internal static int __PropertyOffset_ImmuneBuffTags;

		// Token: 0x0400FB4D RID: 64333
		[Nullable(2)]
		private FGameplayTagContainer _ImmuneBuffTags;
	}
}
